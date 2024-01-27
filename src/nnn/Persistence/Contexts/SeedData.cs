namespace Supermarket.API.Persistence.Contexts
{
    public static class SeedData
    {
        public static async Task Seed(AppDbContext context)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 100,
                    Name = "Apple",
                    QuantityInPackage = 1,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    CategoryId = 100
                },
                new Product
                {
                    Id = 101,
                    Name = "Milk",
                    QuantityInPackage = 2,
                    UnitOfMeasurement = UnitOfMeasurement.Liter,
                    CategoryId = 101,
                },
                new Product
                {
                    Id = 102,
                    Name = "Banana",
                    QuantityInPackage = 1,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    CategoryId = 100
                },
                new Product
                {
                    Id = 103,
                    Name = "Orange Juice",
                    QuantityInPackage = 1,
                    UnitOfMeasurement = UnitOfMeasurement.Liter,
                    CategoryId = 101,
                },
                new Product
                {
                    Id = 104,
                    Name = "Carrot",
                    QuantityInPackage = 500,
                    UnitOfMeasurement = UnitOfMeasurement.Gram,
                    CategoryId = 100
                }
            };

            var categories = new List<Category>
            {
                new Category { Id = 100, Name = "Fruits and Vegetables" }, 
                new Category { Id = 101, Name = "Dairy" },
                new Category { Id = 102, Name = "Beverages" },
                new Category { Id = 103, Name = "Produce" }
            };

            context.Products.AddRange(products);
            context.Categories.AddRange(categories);

            await context.SaveChangesAsync();
        }
    }
}