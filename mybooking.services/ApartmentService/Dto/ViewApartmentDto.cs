namespace mybooking.services.ApartmentService.Dto;

public class ViewApartmentDto
{
    public long   Id          { get; set; }
    public string RoomNumber  { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool   IsBeachView { get; set; } = false;
    public bool   IsLakeView  { get; set; } = false;
    public string RoomStatus  { get; set; }

    public string RoomClass     { get; set; } = string.Empty;
    public string ApartmentType { get; set; } = string.Empty;
}