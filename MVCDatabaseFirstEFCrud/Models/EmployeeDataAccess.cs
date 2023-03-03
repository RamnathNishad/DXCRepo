using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDatabaseFirstEFCrud.Models
{
    public class EmployeeDataAccess
    {
        public List<tbl_employee> GetEmps()
        {
            using (var dbCtx=new DXCDBEntities())
            {
                return dbCtx.tbl_employee.ToList();
            }
        }

        public tbl_employee GetEmpbyId(int empId)
        {
            using (var dbCtx = new DXCDBEntities())
            {
                return dbCtx.tbl_employee
                            .Where(o=>o.ecode==empId)
                            .SingleOrDefault();
            }
        }


        public void AddEmployee(tbl_employee employee)
        {
            using(var dbCtx=new DXCDBEntities())
            {
                dbCtx.tbl_employee.Add(employee);
                dbCtx.SaveChanges(); //makes changes to database
            }
        }

        public void DeleteEmployee(int ecode)
        {
            using (var dbCtx = new DXCDBEntities())
            {
                //find the record for deletion
                var record = dbCtx.tbl_employee
                                  .Where(e => e.ecode == ecode)
                                  .SingleOrDefault();

                if (record != null)
                {
                    dbCtx.tbl_employee.Remove(record);
                    dbCtx.SaveChanges(); //makes changes to database
                }
               
            }
        }

        public void UpdateEmp(tbl_employee employee)
        {
            using (var dbCtx = new DXCDBEntities())
            {
                //find the record for updation
                var record = dbCtx.tbl_employee
                                  .Where(e => e.ecode == employee.ecode)
                                  .SingleOrDefault();

                if (record != null)
                {
                    record.ename = employee.ename;
                    record.salary= employee.salary;
                    record.deptid= employee.deptid;

                    dbCtx.SaveChanges(); //makes changes to database
                }

            }
        }
    }
}