namespace mybooking.services.SecurityService.Dto;

public class UserViewDto : BaseViewDto<Guid>
{
    public string Username { get; set; } = string.Empty;
    public string Email    { get; set; } = string.Empty;
    public string Phone    { get; set; } = string.Empty;
}