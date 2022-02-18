﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealtorNC.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public String Name { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} Must be at least {2} characters long.", MinimumLength = 6)]
        public String Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }


    }
}
