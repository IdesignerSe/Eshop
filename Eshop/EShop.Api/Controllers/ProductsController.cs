
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Domain.Models;

namespace EShop.Api.Controllers
{
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        public ProductsController()
        {

        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var product = new Product();

            product.Id = 1;
            product.Name = "Ip Camera";
            product.Price = 12.23f;

            return Ok(product);
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
