using System.ComponentModel.DataAnnotations;
using mybooking.services.Constants;

namespace mybooking.services.SecurityService.Dto;

public class UserLoginDto
{
    [Required(ErrorMessage = ErrorMessages.USERNAME_REQUIRED)]
    public string UsernameOrEmail { get; set; } = string.Empty;

    [Required(ErrorMessage = ErrorMessages.PASSWORD_REQUIRED)]
    public string Password { get; set; } = string.Empty;
}