using HRMSPrj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMSPrj.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDataAccess empDal = new EmployeeDataAccess();

        // GET: Employee
        public ActionResult Index()
        {
            //get all the employees for display
            
            var lstEmps = empDal.GetEmps();

            //add the data to the View
            ViewData.Add("emps", lstEmps);

            return View();
        }

        public ActionResult Home()
        {
            //get all the employees for display
            var empDal = new EmployeeDataAccess();
            var lstEmps = empDal.GetEmps();

            //pass the model instance inside the View
            return View(lstEmps);
        }

        [HttpGet]
        public ActionResult Display() 
        {
            //get all the employees for display
            //var empDal = new EmployeeDataAccess();

            var lstEmps = empDal.GetEmps();

            //pass the model instance inside the View
            return View(lstEmps);
        }


        [HttpGet]
        public ActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginForm(UserDetails user)
        {
            if(user.uname=="admin" && user.pwd=="abc")
            {
                ViewData.Add("msg", "Welcome to my MVC App-Login successfull");
            }
            else
            {
                ViewData.Add("msg", "invalid username and password, login failed");
            }

            return View("Welcome");
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                //check ecode already existing in database
                var record = empDal.GetEmpById(emp.Ecode); //server-side validation
                if(record!=null)
                {
                    ModelState.AddModelError("Ecode", "ecode already exist");
                }
            }


            if (ModelState.IsValid)
            {
                //insert the record
                empDal.AddEmployee(emp);
                return RedirectToAction("Display");
            }
            else
            {
                return View(emp);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            //delete the record
            empDal.RemoveEmployee(id);
            return RedirectToAction("Display");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            //get the record by id
            var emp = empDal.GetEmpById(id);
            return View(emp);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //get the record by id
            var emp = empDal.GetEmpById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            //update the record by id
            empDal.UpdateEmp(emp);
            return RedirectToAction("Display");
        }
    }
}