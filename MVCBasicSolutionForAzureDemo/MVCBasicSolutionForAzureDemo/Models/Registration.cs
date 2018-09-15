using MVCBasics.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Models
{
    public class Registration
    {
        [Required(ErrorMessage ="UserName is required")]
        [Remote("CheckUserExist","Home",ErrorMessage ="UserName is already exist")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email Id")]
        [DataType(DataType.EmailAddress,ErrorMessage ="EailAddress is not correct")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        [Salary]
        public string Salary { get; set; }
    }
}