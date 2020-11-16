using AdventureWorks.Data.Models;
using System.Collections.Generic;

namespace AdventureWorks.Tests
{
    public class ProductsServiceTestsData
    {
        public Product Product = new Product()
        {
            ProductID = 1,
            Name = "Product A"
        };

        public List<Product> Products = new List<Product>()
        {
            new Product()
            {
                ProductID = 1,
                Name = "Product A"
            },
            new Product()
            {
                ProductID = 2,
                Name = "Product B"
            },
            new Product()
            {
                ProductID = 3,
                Name = "Product C"
            }
        };
    }
}