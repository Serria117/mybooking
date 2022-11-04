namespace mybooking.services;

public abstract class BaseDto<TKey>
{
    public TKey?     Id                { get; set; }
    public DateTime  CreationTime      { get; set; }
    public DateTime? LastUpdatedTime   { get; set; }
    public string?   CreatedByUser     { get; set; }
    public string?   LastUpdatedByUser { get; set; }
}