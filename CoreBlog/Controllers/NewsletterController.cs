using BusinessLayer.Abstract;
using CoreBlog.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class NewsletterController : Controller
    {
        INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpGet]
        public PartialViewResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Index(NewsletterById newsletterById, Newsletter p)
        {
            _newsletterService.Add(p);

            if (newsletterById.BlogId > 0)
            {
                return RedirectToAction("Detail", "Blog", new { id = newsletterById.BlogId });
            }
            else
            {
                return RedirectToAction("Index", "About");
            }
        }
    }
}
