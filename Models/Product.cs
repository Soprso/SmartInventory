using System;

namespace SmartInventory.Models;

public class Product:IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public double Price { get; set; }
}
