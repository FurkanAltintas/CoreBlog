using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(int code)
        {
            return View();
        }
    }
}
