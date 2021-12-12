﻿using System.ComponentModel.DataAnnotations;

namespace Blog.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="User Name")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
