using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirstEFCrud.Models
{
    public class CustomerDataAccessLayer
    {
        public List<tbl_customer> GetCustomers()
        {
            //use EF to get all the customers record
            using(var dbCtx=new CustomerDBEntities())
            {
                return dbCtx.tbl_customer.ToList();
            }
        }

        public void AddCustomer(tbl_customer customer)
        {
            using(var dbCtx=new CustomerDBEntities())
            {
                dbCtx.tbl_customer.Add(customer);
                dbCtx.SaveChanges();
            }
        }

        public tbl_customer GetCustomerById(int id)
        {
            using (var dbCtx=new CustomerDBEntities())
            {
                var customer = dbCtx.tbl_customer.Find(id);

                if(customer!=null)
                {
                    return customer;
                }
                else
                {
                    throw new Exception("customer id not present");
                }
            }
        }
    }
}