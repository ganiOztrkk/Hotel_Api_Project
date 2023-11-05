namespace HotelProject.EntityLayer.Concrete;

public class Service : IEntity
{
    public int ServiceId { get; set; }
    public string? ServiceIcon { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}