using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityManagementSystem.Models;
using CityManagementSystem.ViewModel;

namespace CityManagementSystem.Controllers
{
    public class CountryController : Controller
    {
        ManagementSystemContext context = new ManagementSystemContext();
        // GET: Country
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Country modelCountry)
        {
            Country obj = new Country();
            
            obj.Name = modelCountry.Name;
            obj.About = modelCountry.About;

            context.Countries.Add(obj);
            context.SaveChanges();

            return PartialView();
        }

        public ActionResult CountryTable()
        {
            CountryViewModel model = new CountryViewModel();
            model.Countries = context.Countries.ToList();
            return PartialView(model);
        }
    }
}