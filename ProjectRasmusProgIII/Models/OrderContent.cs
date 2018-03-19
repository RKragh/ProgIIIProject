using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRasmusProgIII.Models
{
    public class OrderContent
    {
        [HiddenInput(DisplayValue = false)]
        public int OrderContentId { get; set; }

        public ShopOrder ShopOrder { get; set; }
        [Display(Name = "Order Number")]
        public int ShopOrderId { get; set; }

        public Product Product { get; set; }
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Display(Name = "Quantity")]
        public int OrderContentQuantity { get; set; }

        [Display(Name = "Price")]
        public double OrderContentPrice { get; set; }

    }
}
