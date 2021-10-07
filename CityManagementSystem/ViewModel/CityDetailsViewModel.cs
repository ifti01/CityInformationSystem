using CityManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityManagementSystem.ViewModel
{
    public class CityDetailsViewModel
    {
        public string CityName { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }
        public Pager Pager { get; set; }
    }
}