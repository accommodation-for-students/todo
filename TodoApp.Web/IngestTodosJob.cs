using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quartz;
using TodoApp.Domain;
using TodoApp.Infrastructure;

namespace TodoApp.Web
{
    public class IngestTodosJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            var builder = new DbContextOptionsBuilder().UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=Todos;Trusted_Connection=True;MultipleActiveResultSets=true");

            var todoContext = new TodoContext(builder.Options);
            var client = new HttpClient();

            var todoDtos = await client.GetFromJsonAsync<IEnumerable<TodoDto>>("https://jsonplaceholder.typicode.com/todos");

            foreach (var todoDto in todoDtos)
            {
                var users = todoContext.Users.ToList();

                foreach (var user in users)
                {
                    if (todoDto.UserId.Equals(user.UserId))
                    {
                        var todo = new Todo
                        {
                            Title = todoDto.Title,
                            Description = string.Empty,
                            Completed = todoDto.Completed,
                        };

                        todo.User = user;

                        todoContext.Todos.Add(todo);
                        todoContext.SaveChanges();
                    }
                }
            }

            var todos = todoContext.Todos.ToList();

            foreach (var todo in todos)
            {
                if (todo.User.Role.Name == "Admin")
                {
                    todoContext.Todos.Remove(todo);
                    todoContext.SaveChanges();
                }
            }
        }
    }
}
