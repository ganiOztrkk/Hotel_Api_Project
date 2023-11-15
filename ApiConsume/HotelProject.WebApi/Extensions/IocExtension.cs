using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;

namespace HotelProject.WebApi.Extensions;

public static class IocExtension
{
    public static IServiceCollection AddInjections(this IServiceCollection services)
    {
        services.AddScoped<IStaffDal, EfStaffDal>();
        services.AddScoped<IStaffService, StaffManager>();
        
        services.AddScoped<IRoomDal, EfRoomDal>();
        services.AddScoped<IRoomService, RoomManager>();
        
        services.AddScoped<IServiceDal, EfServiceDal>();
        services.AddScoped<IServiceService, ServiceManager>();
        
        services.AddScoped<ISubscribeDal, EfSubscribeDal>();
        services.AddScoped<ISubscribeService, SubscribeManager>();
        
        services.AddScoped<ITestimonialDal, EfTestimonialDal>();
        services.AddScoped<ITestimonialService, TestimonialManager>();

        return services;
    }
}