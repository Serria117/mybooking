namespace mybooking.domain;

public abstract class BaseEntity<TK> where TK : struct
{
    public TK        Id             { get; set; }
    public DateTime  CreationTime   { get; set; }
    public DateTime? LastUpdateTime { get; set; }
    public string    CreatedByUser  { get; set; } = string.Empty;
    public string    UpdatedByUser  { get; set; } = string.Empty;

}