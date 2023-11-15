using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            //https://{host}/api/Room
            var rooms = _roomService.GetList();
            return Ok(rooms);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.Insert(room);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            //https://{host}/api/Room?id=4
            var room = _roomService.GetById(id);
            _roomService.Delete(room!);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.Update(room);
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var room = _roomService.GetById(id);
            return Ok(room);
        }
    }
}