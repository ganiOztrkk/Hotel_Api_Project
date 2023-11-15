using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class StaffManager : GenericManager<Staff>, IStaffService
{
    private readonly IStaffDal _staffDal;

    public StaffManager(IStaffDal staffDal) : base((GenericRepository<Staff>)staffDal)
    {
        _staffDal = staffDal;
    }
}