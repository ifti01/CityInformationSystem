using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityManagementSystem.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}