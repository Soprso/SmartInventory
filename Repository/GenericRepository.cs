using System;
using SmartInventory.Models;

namespace SmartInventory.Repository;

public class GenericRepository<T> : IRepository<T> where T : IEntity
{
    List<T> elem = new List<T>();
    public void AddElement(T item)
    {
        elem.Add(item);
    }
    public void RemoveElement(T item)
    {
        var checkItemExists = elem.Where(e => e.Id == item.Id).FirstOrDefault();
        if (checkItemExists != null)
        {
            elem.Remove(checkItemExists);
        }
    }
    public void UpdateElement(T item)
    {
        var checkItemExists = elem.Where(e => e.Id == item.Id).FirstOrDefault();
        if (checkItemExists != null)
        {
            elem.Remove(checkItemExists);
            elem.Add(item);
        }
    }
    public IEnumerable<T> GetAll()
    {
        return elem;
    }
    public IEnumerable<T> GetByCondition(Func<T, bool> predicate)
    {
        return elem.Where(predicate).ToList();
    }
}
