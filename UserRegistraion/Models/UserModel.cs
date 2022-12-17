using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UserRegistraion.Models
{
    public class UserModel
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter User Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "The Password should contain one 1 Uppercase, 1 Number, 1 Special Char, and 1 Lowercase Char), Min Length (8 Chars)")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password")]
        [Compare("Password", ErrorMessage ="Password should be match with Confirm Password...")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter User Email")]
        [RegularExpression("^[a-zA-Z0-9.!#$%&'*+\\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",ErrorMessage ="PLease Enter Valid Email Address")]
        public string Email { get; set; }

        [RegularExpression(@"^[789]\d{9}$",ErrorMessage ="Enter Proper Contact No")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Select User Gender")]
        [BindProperty]
        public string  Gender { get; set; }

        //public string[] Genders = new[] { "Male", "Female", "Unspecified" };
  
    [Required(ErrorMessage = "PLease Accept Terms")]
        public bool AcceptTerms { get; set; }
        
              
    }
}
