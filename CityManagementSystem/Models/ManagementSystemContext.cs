using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CityManagementSystem.Models
{ 
    public class ManagementSystemContext:DbContext 
    { 
        public DbSet<Country> Countries { get; set; } 
        public DbSet<City> Cities { get; set; }
    }
}