using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityManagementSystem.Models;

namespace CityManagementSystem.ViewModel
{
    public class CountryDetailsViewModel
    {
        public string CountryName { get; set; }
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }
        public Pager Pager { get; set; }
    }
}