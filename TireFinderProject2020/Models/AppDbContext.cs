using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TireFinderProject2020.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        { 
        
        }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
