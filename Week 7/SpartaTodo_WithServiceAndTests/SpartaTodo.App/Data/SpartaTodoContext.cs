using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpartaTodo.App.Models;

namespace SpartaTodo.App.Data;

public class SpartaTodoContext : IdentityDbContext
{
    public SpartaTodoContext(DbContextOptions<SpartaTodoContext> options)
        : base(options)
    {
    }

    public DbSet<Todo> TodoItems{ get; set; }
    public DbSet<Spartan> Spartans { get; set; }
}
