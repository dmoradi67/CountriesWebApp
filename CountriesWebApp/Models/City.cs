using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesWebApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int MyProperty { get; set; }

        /// <summary>
        /// ارتباط با استان
        /// </summary>
        public State State { get; set; }
        public int StateId { get; set; }
    }
}
