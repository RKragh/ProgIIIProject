using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRasmusProgIII.Models
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Category")]
        public Category ProductCategory { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Price")]
        public double ProductPrice { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "path too long"), MinLength(1)]
        public string ProductImagePath { get; set; }



    }
}
