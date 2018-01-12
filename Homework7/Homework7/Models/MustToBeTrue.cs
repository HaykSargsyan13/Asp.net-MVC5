using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework7.Models
{
    public class MustToBeTrue : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is bool && (bool)value;
        }
    }

    public class CorrectDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is DateTime && (DateTime)value > DateTime.Now;
        }
    }
}