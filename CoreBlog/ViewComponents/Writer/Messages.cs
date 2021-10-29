using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Writer
{
    public class Messages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
