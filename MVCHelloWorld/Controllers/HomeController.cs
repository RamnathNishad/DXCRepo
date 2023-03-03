using MVCHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }   
        public ActionResult Display()
        {
            var city = new City();
            var cities = city.GetCities();

            ViewData.Add("cities", cities);
            
            return View();
        }
    }
}