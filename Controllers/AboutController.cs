using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is about controller's Index action");
        }
         public IActionResult History()
        {
            return Content("This is about controller's History action");
        }
         public IActionResult Location()
        {
            return Content("This is about controller's Location action");
        }
    }
}