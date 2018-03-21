using Microsoft.EntityFrameworkCore;
using ProjectRasmusProgIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRasmusProgIII.Data
{
    public class ProductCategoryContext :DbContext
    {

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }


        public ProductCategoryContext(DbContextOptions<ProductCategoryContext> options) : base(options)
        {

        }
    }
}
