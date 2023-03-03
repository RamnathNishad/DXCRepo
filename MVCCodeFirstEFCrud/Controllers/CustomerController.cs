using MVCCodeFirstEFCrud.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirstEFCrud.Controllers
{
    //[RoutePrefix("HRMS")]
    [HandleError]
    public class CustomerController : Controller
    {
        // GET: Customer
        //[Route("Home")]
        public ActionResult Index()
        {
            var dal = new CustomerDataAccessLayer();
            var lstCust = dal.GetCustomers();

            return View(lstCust);
        }

        [HttpGet]
        [Route("Customer/Divide/{a}/{b}")]
       
        public ActionResult DivideNumbers(int a,int b)
        {
            //try
            //{
                var result = a / b;
                ViewData.Add("result", result);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    ViewData.Add("result", "denominator must not be 0");
            //}

            return View();
        }


        [HttpGet]
        //[Route("MyApp/AddCustomer")]
        [Authorize]
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(tbl_customer customer)
        {
            var dal = new CustomerDataAccessLayer();
            dal.AddCustomer(customer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        //[Route("GetCustomerDetails/{id}")]
        public ActionResult Details(int id)
        {
            var dal = new CustomerDataAccessLayer();
            var customer=dal.GetCustomerById(id);

            return View(customer);
        }

        [HttpGet]
        //[Route("GetDetails/{id}/{name}")]
        public ActionResult DetailsView(int id,string name)
        {
            ViewData.Add("id", id);
            ViewData.Add("name", name);
            return View();
        }
    }
}