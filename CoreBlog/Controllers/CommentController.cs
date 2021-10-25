using BusinessLayer.Concrete;
using CoreBlog.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        CommentKey commentKey = new CommentKey();
        public PartialViewResult List(int id)
        {
            return PartialView(commentManager.List(id));
        }

        [HttpGet]
        public PartialViewResult Add()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Add(Comment p)
        {
            commentManager.Add(p);
            return RedirectToAction("Detail", "Blog", new { id = p.BlogId });
        }
    }
}
