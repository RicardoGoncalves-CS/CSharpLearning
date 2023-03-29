using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions options) : base(options)
    {

    }

    DbSet<TodoItem> ToDoItems { get; set; }
}
