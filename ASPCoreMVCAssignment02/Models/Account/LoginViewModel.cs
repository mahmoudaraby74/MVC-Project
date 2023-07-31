﻿using System.ComponentModel.DataAnnotations;

namespace Assignment02.Models.Account
{
        public class LoginViewModel
        {
            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [MinLength(5, ErrorMessage = "Minimum Password Length is 5")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            public bool RemeberMe { get; set; }
        }
   
}
