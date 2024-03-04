﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {

    
        
        private ValidationResult CheckDate(object value, ValidationContext ctx) {
            Temp temp = new Temp();
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            if (value is DateTime)
            {
                DateTime dateToCheck = (DateTime)value;
                if (dateToCheck == DateTime.Today) {
                    TempData["SuccessMessage"] = "Date added successfully";
                    return ValidationResult.Success;
                }

            }
            string msg = "PLease enter valid date";
                return new ValidationResult(msg);

            
        }
    }
}
