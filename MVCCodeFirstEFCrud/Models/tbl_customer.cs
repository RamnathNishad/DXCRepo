using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirstEFCrud.Models
{
    public class tbl_customer
    {
        [Key]
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}