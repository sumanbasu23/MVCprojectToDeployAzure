using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasics.Helpers
{
    public class SalaryAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value !=null)
            {
                int salary = Convert.ToInt32(value);
                if(salary<20000)
                {
                    return new ValidationResult("Salary should be grater than 20000");
                }

               
            }
            return ValidationResult.Success;
        }
    }
}