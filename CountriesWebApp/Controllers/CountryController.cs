using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CountriesWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CountriesWebApp.Controllers
{
    public class CountryController : Controller

    {
        private DataBaseContext _ctx;
        public CountryController(DataBaseContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
           
            return View(_ctx.Countries.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("Name,Description")] Country country)
        {

            if (ModelState.IsValid)
            {
                _ctx.Countries.Add(country);
                _ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
                           
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var CountryObj = _ctx.Countries
                .AsNoTracking()
                .FirstOrDefault(m => m.Id == id);
                if (CountryObj == null)
            {
                return NotFound();
            }
            return View(CountryObj);
            
        }
        [HttpPost]
        public IActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var CountryObj = _ctx.Countries
                .AsNoTracking()
                .FirstOrDefault(m => m.Id == id);
            if (CountryObj == null)
            {
                return NotFound();
            }
            return View(CountryObj);

        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}