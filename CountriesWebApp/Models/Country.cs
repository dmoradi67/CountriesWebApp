using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesWebApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// ارتباط 1 به چند با استان
        /// </summary>
        public virtual ICollection<State> States { get; set; }
    }
}
