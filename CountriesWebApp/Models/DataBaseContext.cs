using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CountriesWebApp.Models
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DataBaseContext"]);
        }

        //public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        //{

        //}

        public DbSet<Country> Countries { get; set;}
        public DbSet<State> states { get; set; }
        public DbSet<City> Cities { get; set; }
    }
   
}
