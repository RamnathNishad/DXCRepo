using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMSPrj.Models
{
    public class EmployeeDataAccess
    {
        static List<Employee> employees=new List<Employee>();
        
        public List<Employee> GetEmps()
        {
            return employees;
        }

        public Employee GetEmpById(int ecode)
        {
            //find the record by ecode
            var record = employees.Where(o => o.Ecode == ecode).SingleOrDefault();

            if (record != null)
            {
                return record;
            }
            return null;
        }

        public void AddEmployee(Employee employee)
        {
            if (employees != null)
            {
                employees.Add(employee);
            }
        }
        public void RemoveEmployee(int ecode)
        {
            //find the record for deletion
            var record = employees.Where(o => o.Ecode == ecode).SingleOrDefault();

            if (record != null)
            {
                employees.Remove(record);
            }
        }

        public void UpdateEmp(Employee employee)
        {
            //find the record for updation
            var record = employees.Where(o => o.Ecode == employee.Ecode).SingleOrDefault();

            if (record != null)
            {
                //update the details of the employee
                record.Ename= employee.Ename;
                record.Salary= employee.Salary;
                record.Deptid= employee.Deptid;
            }
            else
            {
                throw new Exception("Ecode does not exist");
            }
        }
    }
}