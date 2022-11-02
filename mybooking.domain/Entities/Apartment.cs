using System.ComponentModel.DataAnnotations.Schema;
using mybooking.domain.Enum;

namespace mybooking.domain.Entities;

[Table("apartment")]
public class Apartment : BaseEntity<long>
{
    public string     RoomNumber  { get; set; } = string.Empty;
    public string     Description { get; set; } = string.Empty;
    public bool       IsBeachView { get; set; } = false;
    public bool       IsLakeView  { get; set; } = false;
    public RoomStatus RoomStatus  { get; set; } = RoomStatus.Available;

    public virtual RoomClass RoomClass { get; set; } = new();
}