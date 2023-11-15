using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class TestimonialManager : GenericManager<Testimonial>, ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal) : base((GenericRepository<Testimonial>)testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }
}