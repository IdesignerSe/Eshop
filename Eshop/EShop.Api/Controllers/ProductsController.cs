
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EShop.Api.Services;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using EShop.Domain.Models;
using EShop.Api.Interfaces;



namespace EShop.Api.Controllers
{
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ISeeder _seeder;
        private ProductsController (ISeeder seeder)
        {
            _seeder = seeder;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {

            return Ok(_seeder.GetAllProducts());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAllProductsById(int id)
        {
            var product = new Product();

            product.Id = id;
            product.Name = "Ip Camera";
            product.Price = 12.23f;

            return Ok(product);
        }

    }
}
