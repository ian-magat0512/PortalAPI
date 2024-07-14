using Microsoft.EntityFrameworkCore;
using PortalAPI.Data;
using PortalAPI.Model;
using System.Linq;

namespace PortalAPI
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            // Ensure database is created and migrations are applied
            context.Database.Migrate();

            // Check if there are any products already in the database
            if (!context.Products.Any())
            {
                // Add seed data
                var products = new[]
                {
                    new Products { Name = "Product 1", Description = "Description for Product 1", Price = 9.99m },
                    new Products { Name = "Product 2", Description = "Description for Product 2", Price = 19.99m },
                    new Products { Name = "Product 3", Description = "Description for Product 3", Price = 29.99m }
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
