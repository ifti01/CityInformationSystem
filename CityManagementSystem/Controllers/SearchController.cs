using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityManagementSystem.Models;
using CityManagementSystem.ViewModel;
using PagedList.Mvc;
using PagedList;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;

namespace CityManagementSystem.Controllers
{
    public class SearchController : Controller
    {
        ManagementSystemContext context = new ManagementSystemContext();
        // GET: Search
        public ActionResult Search(string cityName, int? countryId)
        {
            CityDetailsViewModel viewModel = new CityDetailsViewModel();

            viewModel.CityName = cityName;
            viewModel.CountryId = countryId;
            viewModel.Countries = context.Countries.ToList();

            var citydetail = context.Cities.Include(c=> c.Country).AsQueryable();

            if (!string.IsNullOrEmpty(cityName))
            {
                citydetail = citydetail.Where(c => c.Name.ToLower().Contains(cityName.ToLower()));
            }

            if (countryId.HasValue && countryId.Value > 0)
            {
                citydetail = citydetail.Where(c => c.countryId == countryId.Value);
            }

            viewModel.Cities = citydetail.ToList();

            return View(viewModel);
        } 

        

    }
}