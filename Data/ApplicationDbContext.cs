// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using CqrsDemo.Models;

namespace CqrsDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}