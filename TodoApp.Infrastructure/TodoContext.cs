using Microsoft.EntityFrameworkCore;
using TodoApp.Domain;

namespace TodoApp.Infrastructure
{
    public sealed class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
