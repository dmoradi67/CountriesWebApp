using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CountriesWebApp.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set;}
        public DbSet<State> states { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
