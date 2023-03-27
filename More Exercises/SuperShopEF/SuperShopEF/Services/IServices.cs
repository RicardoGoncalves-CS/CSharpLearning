using SuperShopData.Models;

namespace SuperShopData.Services;

public interface IServices<T>
{
    List<T> GetEntitiesList();

    T GetById(int Id);

    void Create(T entity);

    void Remove(T entity);

    void Save();
}
