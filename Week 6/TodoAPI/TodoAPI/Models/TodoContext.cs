using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<TodoItem> ToDoItems { get; set; }
}
