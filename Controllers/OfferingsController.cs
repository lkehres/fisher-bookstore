using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class OfferingsController : Controller
{
     [Route("Products")]
     [Route("Products/Index")]

     public IActionResult Products()
     {
         return Content("This is the products page.");
    }
    [Route("Services")]
    [Route("Services/Index")]

    public IActionResult Services()
    {
        return Content("This is the services page.");
    }
}
}