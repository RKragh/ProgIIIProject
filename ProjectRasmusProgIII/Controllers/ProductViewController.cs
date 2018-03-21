using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectRasmusProgIII.Data;
using ProjectRasmusProgIII.Models;

namespace ProjectRasmusProgIII.Controllers
{
    public class ProductViewController : Controller
    {
        private readonly DatabaseContext dbcontext;

        public ProductViewController(DatabaseContext context)
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
            //List<SelectListItem> CatList = new List<SelectListItem>();

            //var c = dbcontext.Category.ToList();

            //foreach (var item in c)
            //{
            //    CatList.Add(new SelectListItem { Text = item.CategoryName, Value = item.CategoryId.ToString() });
            //}
            ProductView productView = new ProductView();


            productView.Category = dbcontext.Category.ToList();
            return View(productView);
        }

        [HttpPost]
        public IActionResult Create(ProductView productView)
        {
            productView.Product.ProductId = 0;
            

            dbcontext.Product.Add(productView.Product);
            dbcontext.SaveChanges();
            return RedirectToAction("Product", "Browse");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductView p = new ProductView();
            p.Product = dbcontext.Product.Find(id);

            p.Category = dbcontext.Category.ToList();

            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(ProductView product)
        {
            var p = dbcontext.Product.Find(product.Product.ProductId);
            p = product.Product;
            dbcontext.SaveChanges();

            return Redirect("Browse");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product product = dbcontext.Product.Find(id);
            dbcontext.Product.Remove(product);

            return View("Browse");
        }

        [HttpGet]
        public IActionResult Browse()
        {
            List<ProductView> pviewlist = new List<ProductView>();
            var catList = dbcontext.Category.ToList();

            ProductView pview = new ProductView();
            var p = dbcontext.Product.ToList();
            foreach (var item in p)
            {
                pview.Product = item;
                pview.Category = catList;

                pviewlist.Add(pview);
            }

            ViewBag.list = catList;

            return View(pviewlist);
        }
    }
}