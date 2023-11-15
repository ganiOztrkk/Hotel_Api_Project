using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            //https://{host}/api/Subscribe
            var subscribes = _subscribeService.GetList();
            return Ok(subscribes);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.Insert(subscribe);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            //https://{host}/api/Subscribe?id=4
            var subscribe = _subscribeService.GetById(id);
            _subscribeService.Delete(subscribe!);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.Update(subscribe);
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var subscribe = _subscribeService.GetById(id);
            return Ok(subscribe);
        }
    }
}
