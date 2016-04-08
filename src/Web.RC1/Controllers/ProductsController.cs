using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.RC1.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        public IEnumerable<Models.Product> Get()
        {
            return new[] {
                new Models.Product() { Id = 1, Name= "Produto 1", Value = 10.5m  },
                new Models.Product() { Id = 2, Name= "Produto 2", Value = 10m }
            };
        }
    }
}
