using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete;

public class Context : IdentityDbContext<AppUser, AppRole, int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=HotelApiDb; User Id=sa; Password=148951753Gg(.); TrustServerCertificate=True; Encrypt=False;");
    }

    public DbSet<Room>? Rooms { get; set; }
    public DbSet<Service>? Services { get; set; }
    public DbSet<Staff>? Staffs { get; set; }
    public DbSet<Subscribe>? Subscribes { get; set; }
    public DbSet<Testimonial>? Testimonials { get; set; }
}