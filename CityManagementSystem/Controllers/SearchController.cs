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
using System.Collections;

namespace CityManagementSystem.Controllers
{
    public class SearchController : Controller
    {
        ManagementSystemContext context = new ManagementSystemContext();
        // GET: Search
        public ActionResult Search(string countryName, int? countryId, int? pageNo, int pageSize = 3)
        {
            pageNo = pageNo ?? 1;
            int skipCount = (int)(pageSize * (pageNo - 1));



            CityDetailsViewModel viewModel = new CityDetailsViewModel();

            viewModel.CountryName = countryName;
            viewModel.CountryId = countryId;
            viewModel.Countries = context.Countries.ToList();

            var citydetail = context.Cities.Include(c=> c.Country).AsQueryable();

            if (!string.IsNullOrEmpty(countryName))
            {
                citydetail = citydetail.Where(c => c.Name.ToLower().Contains(countryName.ToLower()));
            }

            if (countryId.HasValue && countryId.Value > 0)
            {
                citydetail = citydetail.Where(c => c.countryId == countryId.Value);
            }

            var totalcity = citydetail.Count();
            viewModel.Pager = new Pager(totalcity, pageNo, pageSize);



            viewModel.Cities = citydetail.OrderByDescending(c => c.Name).Skip(skipCount).Take(pageSize).ToList();

            return View(viewModel);
        }

        public ActionResult CountrySearch(string countryName,int? pageNo, int pageSize = 3)
        {
            pageNo = pageNo ?? 1;
            int skipCount = (int)(pageSize * (pageNo - 1));


            CountryDetailsViewModel viewModel = new CountryDetailsViewModel();

            viewModel.CountryName = countryName;
            

            var countrydetail = context.Countries.AsQueryable();

            if (!string.IsNullOrEmpty(countryName))
            {
                countrydetail = countrydetail.Where(c => c.Name.ToLower().Contains(countryName.ToLower()));
            }

            
            var totalcountry = countrydetail.Count();
            
            viewModel.Pager = new Pager(totalcountry, pageNo, pageSize);

            viewModel.Countries = countrydetail.OrderBy(c => c.Name).Skip(skipCount).Take(pageSize).Include(c=>c.Cities).ToList();
            
            return View(viewModel);

        }

    }
}