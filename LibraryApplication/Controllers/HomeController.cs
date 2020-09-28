using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("This is Controller Index Page");
            return View();
        }
    }
}
