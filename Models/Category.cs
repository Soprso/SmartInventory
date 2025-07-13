using System;

namespace SmartInventory.Models;

public class Category : IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
