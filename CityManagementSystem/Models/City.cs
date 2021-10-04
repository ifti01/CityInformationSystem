using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityManagementSystem.Models
{
    public class City
    {
        //[Key]
        //public int CId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } 
        public string About { get; set; }
        public int DwellerNo { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }

        public int countryId { get; set; }
        public virtual Country Country { get; set; }
    }
}