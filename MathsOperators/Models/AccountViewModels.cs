using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MathsOperators.Models
{
    // Models returned by AccountController actions.
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email/UserName")]
        public string EmailOrUserName { get; set; }

        [Required]
        [Display(Name = "Date of brith")]
        public string DateOfBirth { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email/UserName")]
        public string EmailOrUserName { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email/UserName")]
        public string EmailOrUserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email/UserName")]
        public string EmailOrUserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Grade/Class")]
        public string Grade { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression("yyyy/mmm/dd",ErrorMessage ="Enter date of birth as year/month/day:yyyy/mmm/dd")]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name ="Name of your school")]
        public string School { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [Display(Name = "Email/UserName")]
        public string EmailOrUserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "Email/UserName")]
        public string EmailOrUserName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Date of birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
