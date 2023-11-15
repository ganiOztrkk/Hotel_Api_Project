using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            //https://{host}/api/Testimonial
            var testimonials = _testimonialService.GetList();
            return Ok(testimonials);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.Insert(testimonial);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            //https://{host}/api/Testimonial?id=4
            var testimonial = _testimonialService.GetById(id);
            _testimonialService.Delete(testimonial!);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.Update(testimonial);
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var testimonial = _testimonialService.GetById(id);
            return Ok(testimonial);
        }
    }
}
