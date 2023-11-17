using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        
        [HttpGet]
        public IActionResult AboutList()
        {
            //https://{host}/api/Service
            var abouts = _aboutService.GetList();
            return Ok(abouts);
        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.Insert(about);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            //https://{host}/api/Service?id=4
            var about = _aboutService.GetById(id);
            _aboutService.Delete(about!);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.Update(about);
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var about = _aboutService.GetById(id);
            return Ok(about);
        }
    }
}
