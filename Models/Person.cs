using System.ComponentModel.DataAnnotations;
namespace ProjectName.Models
{
    public class Person
    {
            // First Name //
        [Required]
        [MinLength(4, ErrorMessage="first name must be at least 4 characters long")]
        [Display(Name = "First Name: ")]
        public string FirstName {get; set;}
            // Last Name //
        [Required]
        [MinLength(4, ErrorMessage="last name must be at least 4 characters long")]
        [Display(Name = "Last Name: ")]
        public string LastName {get; set;}
            // Person's Age //
        [Required]
        [Range(0,400, ErrorMessage="age must be a valid number")]
        [Display(Name = "Your Age: ")]
        public int Age {get; set;}
            // Email Address //
        [Required]
        [EmailAddress(ErrorMessage="must be a valid email address")]
        [Display(Name = "Email: ")]
        public string Email {get; set;}
            // Password //
        [Required]
        [MinLength(8, ErrorMessage="password must be at least 8 characters long")]
        [Display(Name = "Password: ")]
        public string Password {get; set;}
    }
}