using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract;

public interface IGenericService<T> where T:class, IEntity, new()
{
    void Insert(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetList();
    T? GetById(int id);
}