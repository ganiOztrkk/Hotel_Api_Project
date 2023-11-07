using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Repository;

public class GenericRepository<T> : IGenericDal<T> where T: class, IEntity
{
    private readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
    }

    public void Insert(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public List<T> GetList()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }
}