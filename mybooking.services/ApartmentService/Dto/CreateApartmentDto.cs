namespace mybooking.services.ApartmentService.Dto;

public class CreateApartmentDto
{
    public long?  Id          { get; set; }
    public string RoomNumber  { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool   IsBeachView { get; set; } = false;
    public bool   IsLakeView  { get; set; } = false;
    public long   RoomStatus  { get; set; }

    public long RoomClass     { get; set; }
    public long ApartmentType { get; set; }
}