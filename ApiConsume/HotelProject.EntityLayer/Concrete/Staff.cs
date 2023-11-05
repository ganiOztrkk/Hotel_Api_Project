namespace HotelProject.EntityLayer.Concrete;

public class Staff : IEntity
{
    public int StaffId { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? SocialMedia1 { get; set; }
    public string? SocialMedia2 { get; set; }
    public string? SocialMedia3 { get; set; }
}