
using System;
using System.ComponentModel.DataAnnotations;


namespace SharpScape.Website.Pages.RegistrationForm

{
    public class User
    {
        [Display(Name = "First Name*:")]
     //   [Required(ErrorMessage = "You must specify your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name:")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name*:")]
     //   [Required(ErrorMessage = "You must specify your last name.")]
        public string LastName { get; set; }

        [Display(Name = "Email*:")]
     //   [Required(ErrorMessage = "You must specify email.")]
        public string Email { get; set; }

        [Display(Name = "Password*:")]
     //   [MinLength(8, ErrorMessage = "Your password should be at least 8 characters.")]
      //  [Required(ErrorMessage = "Your password should be at least 8 characters.")]
        public string Password { get; set; }

   


        public User()
        {
        }
    }
}