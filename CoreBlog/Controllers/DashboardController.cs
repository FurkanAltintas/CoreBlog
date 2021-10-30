using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        StatisticManager statisticManager = new StatisticManager(new EfBlogRepository());
        public IActionResult Index()
        {
            ViewBag.Blog = statisticManager.BlogCount();
            ViewBag.BlogByWriter = statisticManager.BlogByWriterCount(1);
            ViewBag.BlogWeek = statisticManager.BlogWeekCount();
            return View();
        }

        public PartialViewResult Sidebar()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}
