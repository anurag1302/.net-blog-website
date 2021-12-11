using System.ComponentModel.DataAnnotations;

namespace Blog.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name ="User Name")]
        [Required]
        public string UserName { get; set; }
        
        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        
        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
