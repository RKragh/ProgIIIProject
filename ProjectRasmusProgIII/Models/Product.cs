﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectRasmusProgIII.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Category")]
        public string ProductCategory { get; set; }
        [Required]
        [Display(Name = "Price")]
        public double ProductPrice { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "path too long"), MinLength(1)]
        public string ProductImagePath { get; set; }

    }
}
