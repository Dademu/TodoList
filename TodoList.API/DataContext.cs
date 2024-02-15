using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.API
{
    public class DataContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string_here");
        }
    }
}
