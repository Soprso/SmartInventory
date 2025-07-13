using SmartInventory.Models;
using SmartInventory.Repository;

class Program
{
    static void Main()
    {
        var productRepo = new GenericRepository<Product>();
        var categoryRepo = new GenericRepository<Category>();

        categoryRepo.AddElement(new Category { Id = 1, Name = "Electronics" });
        categoryRepo.AddElement(new Category { Id = 2, Name = "Shoes" });
        categoryRepo.AddElement(new Category { Id = 3, Name = "Books" });

        var electronics = categoryRepo.GetByCondition(c => c.Name == "Electronics").FirstOrDefault();
        var shoes = categoryRepo.GetByCondition(c => c.Name == "Shoes").FirstOrDefault();
        var books = categoryRepo.GetByCondition(c => c.Name == "Books").FirstOrDefault();
        //adding products by category
        if (electronics != null)
        {
            var p1 = new Product
            {
                Id = 1,
                Name = "Samsung Galaxy S24",
                Description = "Flagship phone with AMOLED Display",
                Price = 100
            };
            productRepo.AddElement(p1);
            electronics.Products.Add(p1); //Added to ICollection
        }
        if (electronics != null)
        {
            var p2 = new Product
            {
                Id = 2,
                Name = "Nothing Watch 3",
                Description = "Smart watch with  Super Retina AMOLED Display",
                Price = 150
            };
            productRepo.AddElement(p2);
            electronics.Products.Add(p2); //Added to ICollection
        }
        if (shoes != null)
        {
            var p3 = new Product
            {
                Id = 3,
                Name = "Nike Air",
                Description = "Running Shoes",
                Price = 30
            };
            productRepo.AddElement(p3);
            shoes.Products.Add(p3); //Added to ICollection
        }
        if (books != null)
        {
            var p4 = new Product
            {
                Id = 4,
                Name = "Introduction To C#",
                Description = "Zero to Hero in C#",
                Price =10
            };
            productRepo.AddElement(p4);
            books.Products.Add(p4); //Added to ICollection
        }

        //displaying products by category
        System.Console.WriteLine();
        System.Console.WriteLine("All Categories and Products:");
        var allCategories = categoryRepo.GetAll();
        foreach (var cat in allCategories)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Category :");
            foreach (var prod in cat.Products)
            {
                System.Console.WriteLine($" - Name  -> {prod.Name}, Price -> {prod.Price}, Descrption -> {prod.Description}");
            }
        }
    }
}