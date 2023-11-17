using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.Requests.LoginDto;
using HotelProject.WebUI.Dtos.Requests.RegisterDto;
using HotelProject.WebUI.Dtos.Requests.ServiceDto;
using HotelProject.WebUI.Dtos.Responses.ServiceDto;

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
    }
}