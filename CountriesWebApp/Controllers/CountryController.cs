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
        public IActionResult Create()
        {

            return View();
        }
    }
}