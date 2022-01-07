using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO
{
    public class UserForRegistrationDto
    {

        [Required(ErrorMessage = "First name is a required field.")]
        [MaxLength(12, ErrorMessage = "Maximum length for the Name is 12 characters.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is a required field.")]
        [MaxLength(16, ErrorMessage = "Maximum length for the Name is 16 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")] 
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")] 
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")] 
        public string ConfirmPassword { get; set; }
    }
}
