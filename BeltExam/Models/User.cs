#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeltExam.Models;

namespace BeltExam.Models;

public class User{
     [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Last Name is required.")]
    [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters.")]
    public string LastName { get; set; }

    [Required]
    [UniqueUsername]
    public string Username{ get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    [NotMapped]
    [Required(ErrorMessage = "Confirm Password is required.")]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string PasswordConfirm { get; set; }
}
public class UniqueUsernameAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) {
        if (value == null) {
            return new ValidationResult("Email is required.");
        }

        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
        if (_context.Users.Any(e => e.Username == value.ToString())) {
            return new ValidationResult("This Username is already registered.");
        } else {
            return ValidationResult.Success;
        }
    }
}