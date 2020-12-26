using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using RESTfulAPI.Models;

namespace RESTfulAPI.CustomAttributes
{
    public class SexAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var elephant = (ElephantTargetBinding)validationContext.ObjectInstance;

            if (elephant.Sex != "Male" && elephant.Sex != "Female")
            {
                return new ValidationResult("Sex should be described as \"Female\" or \"Male\".");
            }

            return ValidationResult.Success;
        }
    }
}