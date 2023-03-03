using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirstEFCrud.Controllers
{
    public class StatemanagementController : Controller
    {
        // GET: Statemanagement
        public ActionResult Index()
        {
            ViewData.Add("x", 100);
            TempData.Add("y", 200);
            ViewBag.City = "Bangalore";

            Session.Add("Z", 300);
            return View();
        }

        public ActionResult Second() 
        {
            return View();
        }
    }
}