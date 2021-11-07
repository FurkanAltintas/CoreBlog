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
        StatisticManager statisticManager = new StatisticManager
            (
            new EfBlogRepository(),
            new EfCategoryRepository()
            );
        public IActionResult Index()
        {
            DateTime date = DateTime.Now;
            ViewBag.Blog = statisticManager.BlogCount();
            ViewBag.BlogDay = statisticManager.Blog().Where(x=>x.CreateDate.Year == date.Year && x.CreateDate.Month == date.Month && x.CreateDate.Day == date.Day).Count();
            ViewBag.BlogMonth = statisticManager.Blog().Where(x => x.CreateDate.Year == date.Year && x.CreateDate.Month == date.Month).Count();
            ViewBag.BlogYear = statisticManager.Blog().Where(x => x.CreateDate.Year == date.Year).Count();
            
            ViewBag.BlogByWriter = statisticManager.BlogByWriterCount(1);
            ViewBag.BlogWriterDay = statisticManager.Blog().Where(x => x.WriterId == 1 & x.CreateDate.Year == date.Year & x.CreateDate.Month == date.Month & x.CreateDate.Day == date.Day).Count();
            ViewBag.BlogWriterMonth = statisticManager.Blog().Where(x => x.WriterId == 1 & x.CreateDate.Year == date.Year & x.CreateDate.Month == date.Month).Count();
            ViewBag.BlogWriterYear = statisticManager.Blog().Where(x => x.WriterId == 1 & x.CreateDate.Year == date.Year).Count();

            ViewBag.Category = statisticManager.Category();
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
