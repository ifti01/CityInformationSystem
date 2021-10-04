using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityManagementSystem.Models;
using CityManagementSystem.ViewModel;

namespace CityManagementSystem.Controllers
{
    public class CityController : Controller
    {
        ManagementSystemContext context = new ManagementSystemContext();

        public ActionResult Index()
        {
            CityViewModel viewModel = new CityViewModel();
            viewModel.Countries = context.Countries.ToList();

            return View();
        }

        public ActionResult Create()
        {
            //Dropdown list e information nicchi Database theke
            
            CityViewModel viewModel = new CityViewModel();
            viewModel.Countries = context.Countries.ToList();
            return PartialView(viewModel);

        }
        [HttpPost]
        public ActionResult Create(CityViewModel modelCity)
        {
            City obj = new City();
            
            obj.Name = modelCity.Name;
            obj.About = modelCity.About;
            obj.DwellerNo = modelCity.DwellerNo;
            obj.Location = modelCity.Location;
            obj.Weather = modelCity.Weather;


            obj.Country = context.Countries.Find(modelCity.Id);


            context.Cities.Add(obj);
            context.SaveChanges();

            //return RedirectToAction("Index");
            return PartialView();
        }

        public ActionResult CityTable()
        {
            CityListViewModel viewModel = new CityListViewModel
            {
                Cities = context.Cities.ToList()
            };
            return PartialView(viewModel);

            //CityViewModel viewmodel = new CityViewModel();
            //viewmodel.Cities = context.Cities.ToList();
            //return PartialView(viewmodel);

        }

    }
}