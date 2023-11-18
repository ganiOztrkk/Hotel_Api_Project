using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.Requests.AboutDto;
using HotelProject.WebUI.Dtos.Requests.LoginDto;
using HotelProject.WebUI.Dtos.Requests.Newsletter;
using HotelProject.WebUI.Dtos.Requests.RegisterDto;
using HotelProject.WebUI.Dtos.Requests.ServiceDto;
using HotelProject.WebUI.Dtos.Requests.StaffDto;
using HotelProject.WebUI.Dtos.Requests.TestimonialDto;
using HotelProject.WebUI.Dtos.Responses.AboutDto;
using HotelProject.WebUI.Dtos.Responses.ServiceDto;
using HotelProject.WebUI.Dtos.Responses.StaffDto;
using HotelProject.WebUI.Dtos.Responses.TestimonialDto;

namespace HotelProject.WebUI.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AddServiceDto, Service>().ReverseMap();
        CreateMap<UpdateServiceDto, Service>().ReverseMap();
        CreateMap<DisplayServiceDto, Service>().ReverseMap();
        
        CreateMap<AddUserDto, AppUser>().ReverseMap();
        CreateMap<LoginUserDto, AppUser>().ReverseMap();
        
        CreateMap<DisplayAboutDto, About>().ReverseMap();
        CreateMap<UpdateAboutDto, About>().ReverseMap();

        CreateMap<AddTestimonialDto, Testimonial>().ReverseMap();
        CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
        CreateMap<DisplayTestimonialDto, Testimonial>().ReverseMap();

        CreateMap<AddStaffDto, Staff>().ReverseMap();
        CreateMap<UpdateStaffDto, Staff>().ReverseMap();
        CreateMap<DisplayStaffDto, Staff>().ReverseMap();

        CreateMap<AddNewsletterDto, Subscribe>().ReverseMap();

    }
}