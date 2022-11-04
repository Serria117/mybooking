using System.ComponentModel.DataAnnotations;
using mybooking.services.Constants;

namespace mybooking.services.SecurityService.Dto;

public class UserRegisterDto
{
    [Required] 
    [MaxLength(50, ErrorMessage = ErrorMessages.USERNAME_LENGTH)] 
    [MinLength(3, ErrorMessage = ErrorMessages.USERNAME_LENGTH)]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = ErrorMessages.EMAIL)] 
    [EmailAddress(ErrorMessage = ErrorMessages.EMAIL)]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = ErrorMessages.PHONE)]
    [RegularExpression("^[0-9]{8,12}$", ErrorMessage = ErrorMessages.PHONE)]
    public string Phone { get; set; } = string.Empty;
    
    [MinLength(6, ErrorMessage = ErrorMessages.PASSWORD_LENGTH), 
     MaxLength(50, ErrorMessage = ErrorMessages.PASSWORD_LENGTH)]
    public string Password { get; set; } = string.Empty;
}