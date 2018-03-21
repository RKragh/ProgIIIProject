using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRasmusProgIII.Models
{
    public class ProductView
    {
        public Product Product { get; set; }
        public List<Category> Category { get; set; }
    }
}
