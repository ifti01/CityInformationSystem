using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityManagementSystem.Controllers
{
    public class CountryController : Controller
    {

        // GET: Country
        public ActionResult Crete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crete(int id)
        {
            return View();
        }
    }
}