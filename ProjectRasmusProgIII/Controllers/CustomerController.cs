using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectRasmusProgIII.Data;
using ProjectRasmusProgIII.Models;

namespace ProjectRasmusProgIII.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DatabaseContext dbcontext;

        public CustomerController(DatabaseContext context)
        {
            dbcontext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customer.CustomerId = 0;

            dbcontext.Customer.Add(customer);
            dbcontext.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Details(int id)
        {
            Customer customer = new Customer();
            customer = dbcontext.Customer.Find(id);

            return View(customer);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Customer customer = new Customer();
            customer = dbcontext.Customer.Find(id);


            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            var c = dbcontext.Customer.First(KongGulerod => KongGulerod.CustomerId == customer.CustomerId);
            c = customer;
            dbcontext.SaveChanges();

            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            var list = dbcontext.Customer.ToList();
            return View(list);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Customer customer = dbcontext.Customer.Find(id);
            dbcontext.Customer.Remove(customer);
            dbcontext.SaveChanges();

            return RedirectToAction("List");
        }





    }
}