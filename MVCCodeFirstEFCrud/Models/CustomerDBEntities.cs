using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirstEFCrud.Models
{
    public class CustomerDBEntities : DbContext
    {
        public CustomerDBEntities() 
            : base("name=constr")
        {

        }

        public virtual DbSet<tbl_customer> tbl_customer { get; set; }
    }
}