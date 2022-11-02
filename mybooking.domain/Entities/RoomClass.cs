using System.ComponentModel.DataAnnotations.Schema;

namespace mybooking.domain.Entities;
[Table("room_class")]
public class RoomClass : BaseEntity<long>
{
    public string ClassName   { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}