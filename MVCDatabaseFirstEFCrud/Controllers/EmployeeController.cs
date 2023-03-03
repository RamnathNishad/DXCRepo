using MVCDatabaseFirstEFCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDatabaseFirstEFCrud.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDataAccess dal;

        public EmployeeController()
        {
            dal = new EmployeeDataAccess();
        }

        // GET: Employee
        public ActionResult Index()
        {
            //get all the employees records
            var lstEmps = dal.GetEmps();

            return View(lstEmps);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_employee emp)
        {
            //insert the record using EF DAL
            dal.AddEmployee(emp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            //delete the record using EF DAL
            dal.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var emp=dal.GetEmpbyId(id);
            return View(emp);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            //get the record for editing using EF DAL
            var emp = dal.GetEmpbyId(id);

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(tbl_employee emp)
        {
            //update the record using EF DAL
            dal.UpdateEmp(emp);
            return RedirectToAction("Index");
        }

    }
}