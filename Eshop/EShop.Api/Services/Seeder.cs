using EShop.Api.Interfaces;
using EShop.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Api.Services
{
    public class Seeder : ISeeder
    {
        private List<Product> _products = new List<Product>();
        public List<Product> GetAllProducts()
        {
            var product1 = new Product
            {
                Id = 1,
                Name = "Logitech IP Camera",
                Description = "Does wonderful videos",
                Price = 34.89f,
            };
            _products.Add(product1);

            var product2 = new Product
            {
                Id = 2,
                Name = "SuperDLux IP Camera",
                Description = "Does Amazing Views",
                Price = 56.10
            };
            _products.Add(product2);
            return _products;
        }
    }
}
