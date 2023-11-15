using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class SubscribeManager : GenericManager<Subscribe>, ISubscribeService
{
    private readonly ISubscribeDal _subscribeDal;

    public SubscribeManager(ISubscribeDal subscribeDal): base((GenericRepository<Subscribe>)subscribeDal)
    {
        _subscribeDal = subscribeDal;
    }
}