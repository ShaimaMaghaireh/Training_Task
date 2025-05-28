using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFormExample.Models
{
    public class UserInputViewModel
    {

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "Must be Nuber start with 079...")]
        public int number { get; set; }

        [EmailAddress(ErrorMessage = "Must be Email form !!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]

        public string confirmPasssword { get; set; }


    }
}