using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class RoomManager : GenericManager<Room>, IRoomService
{
    private readonly IRoomDal _roomDal;

    public RoomManager(IRoomDal roomDal) : base((GenericRepository<Room>)roomDal)
    {
        _roomDal = roomDal;
    }
}