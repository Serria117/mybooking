using System.ComponentModel.DataAnnotations.Schema;

namespace mybooking.domain.Entities;

[Table("apartment_type")]
public class ApartmentType : BaseEntity<long>
{
    public string TypeName    { get; set; } = string.Empty;
    public string Code        { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}