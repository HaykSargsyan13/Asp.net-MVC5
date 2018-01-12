using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework7.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Plesae enter Email")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email is not in Correct format")]
        public string Email { get; set; }
        [CorrectDate(ErrorMessage = "Enter correct Date")]
        public DateTime Data { get; set; }
        [MustToBeTrue(ErrorMessage = "You didn't Accept Terms")]
        public bool TermsAccepted { get; set; }

    }
}