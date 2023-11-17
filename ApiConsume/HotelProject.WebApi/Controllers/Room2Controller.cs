using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Requests.RoomDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IMapper mapper, IRoomService roomService)
        {
            _mapper = mapper;
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var rooms = _roomService.GetList();
            return Ok(rooms);
        }

        [HttpPost]
        public IActionResult AddRoom(AddRoomDto addRoomDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var room = _mapper.Map<Room>(addRoomDto);
            _roomService.Insert(room);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var room = _mapper.Map<Room>(updateRoomDto);
            _roomService.Update(room);
            return Ok("Successfully Updated");
        }
    }
}