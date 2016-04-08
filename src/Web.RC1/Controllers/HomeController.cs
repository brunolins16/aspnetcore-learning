using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Web.RC1.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index() {
            using (var client = new HttpClient()) {
                var jsonResult = await client.GetStringAsync("http://localhost:5000/api/products");
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Product[]>(jsonResult);

                return View((from prod in result select new ViewModels.ProductViewModel(prod)));
            }
        }
    }
}
