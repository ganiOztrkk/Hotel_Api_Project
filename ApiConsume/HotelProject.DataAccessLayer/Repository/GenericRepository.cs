using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Repository;

public class GenericRepository<T> : IGenericDal<T> where T: class, IEntity, new()
{

    public void Insert(T entity)
    {
        using var _context = new Context();
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        using var _context = new Context();
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        using var _context = new Context();
        _context.Update(entity);
        _context.SaveChanges();
    }

    public List<T> GetList()
    {
        using var _context = new Context();
        return _context.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        using var _context = new Context();
        return _context.Set<T>().Find(id);
    }
}