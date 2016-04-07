using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.RC1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
           // return Content("Hello World from Controller");
           return View();
        }
    }
}
