using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class AboutController : Controller
    {
        IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View(_aboutService.Get());
        }
    }
}
