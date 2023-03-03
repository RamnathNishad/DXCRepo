using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSPrj.Models
{
    public class Employee
    {
        [Required]
        [Range(1,int.MaxValue)]
        public int Ecode { get; set; }

        [Required]
        [StringLength(10,MinimumLength =3)]
        [RegularExpression("[A-Z][aA-zZ]*",ErrorMessage ="invalid name, it must be only alphabets and first capital letter")]
        public string Ename { get; set; }

        [Required]      
        [Range(1000,10000)]
        public int Salary { get; set; }

        [Required]
        [Range(200,210)]
        //[DataType("System.Int32")]
        [DeptidCheck(ErrorMessage ="deptid is invalid, it must be either 201,202 or 203")]
        public int Deptid { get; set; }
        
    }

    public class DeptidCheck : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var did = (int)value;
            if(did==201 || did==202 || did==203)
            {
                return true;
            }

            return false;
        }
    }
}