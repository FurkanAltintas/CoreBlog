using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Comment
{
    public class CommentAdd : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
