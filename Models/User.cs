using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        
        
        
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        
        
        
        
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 50 characters")]
        public string LastName { get; set; }

        
        
        
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }

        
        
        
        
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be minimum 6 characters")]
        public string Password { get; set; }
    }
}

