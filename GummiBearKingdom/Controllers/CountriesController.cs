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
            if(ModelState.IsValid){
				db.Countries.Add(country);
				db.SaveChanges(); 
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int countryId)
        {
            var thisCountry = db.Countries.Include(country => country.Products)
                                .FirstOrDefault(country => country.CountryId == countryId);
            return View(thisCountry);
        }

        public IActionResult Edit(int countryId)
        {
            var thisCountry = db.Countries.FirstOrDefault(country => country.CountryId == countryId);
            return View(thisCountry);
        }

        [HttpPost]
        public IActionResult Edit(Country country)
        {
            db.Entry(country).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Details", new { countryId = country.CountryId });
        }

        public IActionResult Delete(int countryId)
        {
            var thisCountry = db.Countries.FirstOrDefault(country => country.CountryId == countryId);
            return View(thisCountry);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmation(int countryId)
        {
            var thisCountry = db.Countries
                                .FirstOrDefault(country => country.CountryId == countryId);
            db.Countries.Remove(thisCountry);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}