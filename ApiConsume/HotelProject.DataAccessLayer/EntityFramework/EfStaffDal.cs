using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfStaffDal : GenericRepository<Staff>, IStaffDal
{
    
}