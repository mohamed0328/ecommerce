using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class SomaliDbContext : DbContext
    {
        //1- Create constractor
        public SomaliDbContext(DbContextOptions<SomaliDbContext> dbContext) :base(dbContext)
        {
                
        }
        //2- Oncreate model

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



        //3- Add your Model Dbsets

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
