using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Controllers
{
    public class CountriesController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();
        public IActionResult Index()
        {
            var CountryList = db.Countries.OrderBy((x => x.Name)).ToList();
            return View(CountryList);
        }
  
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            db.Countries.Add(country);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int countryId)
        {
            var thisCountry = db.Countries.Include(country => country.Products)
                                .FirstOrDefault(country => country.CountryId == countryId);
            return View(thisCountry);
        }

    }
}
