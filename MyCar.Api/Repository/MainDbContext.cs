using Microsoft.EntityFrameworkCore;
using MyCar.Api.Models;
using System.Collections.Generic;

namespace MyCar.Api.Repository
{
    public class MainDbContext : DbContext
    {


       //constractor
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql("Server=localhost;Port=5432;Database=vehicledb20221123; User ID=postgres;Password=12345678");
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
    }
    
    
}
