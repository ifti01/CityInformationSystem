using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityManagementSystem.Models;

namespace CityManagementSystem.ViewModel
{
    public class CityViewModel
    {
        public string Name { get; set; }
        public string About { get; set; }
        public int DwellerNo { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int Id { get; set; }
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }
    }
    //new 
    public class CityListViewModel
    {
        public List<City> Cities { get; set; }
    }


}