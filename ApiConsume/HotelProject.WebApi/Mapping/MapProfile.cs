using AutoMapper;
using HotelProject.DtoLayer.Requests.RoomDtos;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<AddRoomDto, Room>().ReverseMap();
        CreateMap<UpdateRoomDto, Room>().ReverseMap();
    }
}