using Microsoft.AspNetCore.Identity;

namespace HotelProject.EntityLayer.Concrete;

public class AppUser : IdentityUser<int>, IEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? City { get; set; }
}