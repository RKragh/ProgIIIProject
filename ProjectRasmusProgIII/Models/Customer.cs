using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRasmusProgIII.Models
{
    public class Customer
    {
        [HiddenInput(DisplayValue = false)]
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "This field can not be longer than 50 characters"), MinLength(1)]
        public string CustomerFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "This field can not be longer than 50 characters"), MinLength(1)]
        public string CustomerLastName { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public int CustomerPhone { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string CustomerCity { get; set; }
        [Required]
        [Display(Name = "Zip")]
        public int CustomerZipCode { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string CustomerCountry { get; set; }

        public string GetFullAddress()
        {
            string address = "";

            address = CustomerAddress + "\n" +
                      CustomerZipCode + ", " + CustomerCity + "\n" +
                      CustomerCountry;

            return address;
        }
    }
}
