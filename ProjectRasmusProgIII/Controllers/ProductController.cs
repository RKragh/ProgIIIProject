using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectRasmusProgIII.Data;
using ProjectRasmusProgIII.Models;

namespace ProjectRasmusProgIII.Controllers
{
    public class ProductController : Controller
    {
        private readonly DatabaseContext dbcontext;

        public ProductController(DatabaseContext context)
        {
            dbcontext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}