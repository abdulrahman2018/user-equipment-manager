// Models/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;

namespace GarageManagementSystem.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Inventory> Inventory { get; set; }
    }
}

