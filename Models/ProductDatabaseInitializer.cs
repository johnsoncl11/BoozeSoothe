using System.Collections.Generic;
using System.Data.Entity;

namespace BoozeSoothe.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Beverages"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Food"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "P.E.D's"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
        var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Gatorade",
                    Description = "32 oz of pure, electrolyte-packed sports drink sure to bring you back to the land of hydration.",
                    UnitPrice = 4.00,
                    ImagePath = "gatorade.jpg",
                    CategoryID = 1
                },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Ginger Ale",
                    Description = "One of my old college buddies used to say nothing cure's a hangover like a little bit of bubbles.",
                    UnitPrice = 2.50,
                    ImagePath = "gingerale.jpg",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Coffee",
                    Description = "An age-old hangover cure. It's rumored that George Washington drank a cup the morning after celebrating his victories.",
                    UnitPrice = 2.00,
                    ImagePath = "coffee.jpg",
                    CategoryID = 1
                },
                
                new Product
                {
                    ProductID = 4,
                    ProductName = "Chicken Biscuit",
                    Description = "Greasy & Filling, there's not a better combination.",
                    UnitPrice = 4.00,
                    ImagePath = "biscuit.jpg",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Breakfast Burrito",
                    Description = "The contents of this behemoth act as a sponge, attempting to soak up all of those Red Bull Vodkas from last night.",
                    UnitPrice = 3.50,
                    ImagePath = "burrito.jpg",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Glazed Doughnut",
                    Description = "This will put something in your booze-filled stomach.",
                    UnitPrice = 2.50,
                    ImagePath = "donut.jpg",
                    CategoryID = 2
                },
               
                new Product
                {
                    ProductID = 7,
                    ProductName = "5-HTP",
                    Description = "Some call this mood-boosting supplement witchcraft.",
                    UnitPrice = 1.00,
                    ImagePath = "5-HTP.jpg",
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Multivitamin",
                    Description = "Fuel your body with vitamins that you probably haven't had in years.",
                    UnitPrice = 0.75,
                    ImagePath = "multi.jpg",
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Ibuprofen",
                    Description = "Take these and kiss your headache good-bye.",
                    UnitPrice = 0.50,
                    ImagePath = "ibuprofen.jpg",
                    CategoryID = 3
                }
          };
                
      return products;
    }
  }
}
