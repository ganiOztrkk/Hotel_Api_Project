using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class GenericManager<T> : IGenericService<T> where T:class, IEntity, new()
{
    private readonly GenericRepository<T> _genericRepository;

    public GenericManager(GenericRepository<T> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public void Insert(T entity)
    {
        _genericRepository.Insert(entity);
    }

    public void Delete(T entity)
    {
        _genericRepository.Delete(entity);
    }

    public void Update(T entity)
    {
        _genericRepository.Update(entity);
    }

    public List<T> GetList()
    {
        return _genericRepository.GetList();
    }

    public T? GetById(int id)
    {
        return _genericRepository.GetById(id);
    }
}