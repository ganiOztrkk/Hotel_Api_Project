using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _ServiceService;

        public ServiceController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            //https://{host}/api/Service
            var services = _ServiceService.GetList();
            return Ok(services);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _ServiceService.Insert(service);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            //https://{host}/api/Service?id=4
            var service = _ServiceService.GetById(id);
            _ServiceService.Delete(service!);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _ServiceService.Update(service);
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var service = _ServiceService.GetById(id);
            return Ok(service);
        }
    }
}
