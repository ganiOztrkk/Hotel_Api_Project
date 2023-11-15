using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class ServiceManager : GenericManager<Service>, IServiceService
{
    private readonly IServiceDal _serviceDal;

    public ServiceManager(IServiceDal serviceDal) : base((GenericRepository<Service>)serviceDal)
    {
        _serviceDal = serviceDal;
    }
}