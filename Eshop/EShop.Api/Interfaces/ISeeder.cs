using EShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Api.Interfaces
{
    interface ISeeder
    {
        List<Product> GetAllProducts();
    }
}
