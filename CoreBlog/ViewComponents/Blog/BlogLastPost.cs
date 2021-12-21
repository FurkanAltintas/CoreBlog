using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Blog
{
    public class BlogLastPost : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            return View(blogManager.LastPost());
        }
    }
}
