﻿using EShop.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }

    }
}
