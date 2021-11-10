using System;

namespace TodoApp.Domain
{
    public class TodoDto
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }

    public class Todo
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public User User { get; set; }
        public DateTime Created { get; set; }
    }
}
