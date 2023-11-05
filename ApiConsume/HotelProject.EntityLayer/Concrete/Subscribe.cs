namespace HotelProject.EntityLayer.Concrete;

public class Subscribe : IEntity
{
    public int SubscribeId { get; set; }
    public string? Mail { get; set; }
}