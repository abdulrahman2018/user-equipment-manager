// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using GarageManagementSystem.Models;

namespace GarageManagementSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Inventory> Inventory { get; set; }
    }
}
