using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRasmusProgIII.Models
{
    public class ShopOrder
    {
        [HiddenInput(DisplayValue = false)]
        public int ShopOrderId { get; set; }

        public Customer Customer { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int CustomerId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime ShopOrderCreatedDate { get; set; }
        [Display(Name = "Total Price")]
        public double ShopOrderPrice { get; set; }
    }
}
