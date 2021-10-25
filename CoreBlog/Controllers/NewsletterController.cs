using BusinessLayer.Concrete;
using CoreBlog.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager newsletterManager = new NewsletterManager(new EfNewsletterRepository());
        [HttpGet]
        public PartialViewResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Index(NewsletterById newsletterById, Newsletter p)
        {
            newsletterManager.Add(p);
            return RedirectToAction("Detail", "Blog", new { id = newsletterById.BlogId });
        }
    }
}
