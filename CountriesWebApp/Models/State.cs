using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesWebApp.Models
{
    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public int Population { get; set; }
        public String Description { get; set; }
        /// <summary>
        /// ارتباط یک به چند با کشورها
        /// </summary>
        public Country Country { get; set; }
        public int CountryId { get; set; }
        /// <summary>
        /// تعریف کالکشن برای ارتباط با شهر ها
        /// </summary>
        public virtual ICollection<City> cities { get; set; }
    }
}
