using System;

namespace SmartInventory.Repository;

public interface IRepository<T>
{
    void AddElement(T item);
    void RemoveElement(T item);
    void UpdateElement(T item);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetByCondition(Func<T, bool> predicate);
    
}
