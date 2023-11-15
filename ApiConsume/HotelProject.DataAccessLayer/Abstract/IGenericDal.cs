using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract;

public interface IGenericDal<T> where T : class, IEntity, new()
{
    void Insert(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetList();
    T? GetById(int id);
}