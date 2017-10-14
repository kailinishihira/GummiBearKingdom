using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GummiBearKingdom.Controllers
{
    public class Products : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();
        public IActionResult Index()
        {
            var productsList = db.Products.OrderBy((x => x.Name))
                                 .Include(product => product.Country).ToList();
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            return View(productsList);
        }

        public IActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddProduct(int countryId)
        {
            ViewBag.CountryId = db.Countries.FirstOrDefault(product => product.CountryId == countryId);
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Details", "Countries", new { countryId = product.CountryId });
        }

        public IActionResult Details(int productId)
        {
            var thisProduct = db.Products.Include(product => product.Country)
                                .FirstOrDefault(product => product.ProductId == productId);
            return View(thisProduct);
        }

        public IActionResult Edit(int productId)
        {
            var thisProduct = db.Products.Include(product => product.Country)
                                .FirstOrDefault(product => product.ProductId == productId);
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int productId)
        {
            var thisProduct = db.Products.FirstOrDefault(product => product.ProductId == productId);
            return View(thisProduct); 
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmation(int productId)
        {
            var thisProduct = db.Products.FirstOrDefault(product => product.ProductId == productId);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
