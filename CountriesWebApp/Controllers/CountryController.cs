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
        public IActionResult Index()
        {
             DataBaseContext db = new DataBaseContext();
            //var _ctx =
            //    new DataBaseContext(ServiceProvider.GetRequiredService<
            //        DbContextOptions<DataBaseContext>>());

            return View(db.Countries.ToList());
        }
        public IActionResult Create()
        {

            return View();
        }
    }
}