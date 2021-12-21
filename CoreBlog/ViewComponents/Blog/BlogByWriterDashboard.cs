using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CoreBlog.Base;
using DataAccessLayer.Concrete.EntityFramework.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Dashboard
{
    public class BlogByWriterDashboard : ViewComponent
    {
        IBlogService _blogService;

        public BlogByWriterDashboard(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View(_blogService.FetchCategoryByWriter(Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value)));
        }
    }
}
