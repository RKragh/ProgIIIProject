using Microsoft.EntityFrameworkCore;
using ProjectRasmusProgIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRasmusProgIII.Data
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ShopOrder> ShopOrder { get; set; }
        public DbSet<OrderContent> OrderContent { get; set; }
        public DbSet<Category> Category { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
    }
}
