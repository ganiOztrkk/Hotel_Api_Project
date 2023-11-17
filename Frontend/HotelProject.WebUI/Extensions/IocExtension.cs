using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Extensions;

public static class IocExtension
{
    /// <summary>
    /// Extension Fucntion for IOC config.
    /// </summary>
    /// <returns></returns>
    public static IServiceCollection AddInjections(this IServiceCollection services)
    {
        services.AddHttpClient();//api istek için eklediğimiz client containeri
        
        services.AddControllersWithViews()
            .AddRazorOptions(options =>
            {
                options.ViewLocationFormats.Add("/Pages/{0}.cshtml"); // pages içinde components
                options.ViewLocationFormats.Add("/Views/Shared/AdminLayout/{0}.cshtml");
                options.ViewLocationFormats.Add("/Pages/{1}/{0}.cshtml");
                
            })//view ve layout sayfalarını arama configleri.
            .AddRazorRuntimeCompilation();//runtime degisiklikleri gormek icin lib
        
        //automapper lib. icin service
        services.AddAutoMapper(typeof(Program));

        services.AddDbContext<Context>();
        //identity lib. icin service
        services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 4;
            })
            .AddEntityFrameworkStores<Context>();

        return services;
    }
}