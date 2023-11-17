namespace HotelProject.EntityLayer.Concrete;

public class About : IEntity
{
    public int AboutId { get; set; }
    public string? Title1 { get; set; }
    public string? Title2 { get; set; }
    public string? Content { get; set; }
    public int RoomCount { get; set; }
    public int StaffCount { get; set; }
    public int CustomerCount { get; set; }
}