using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_notificationService.Ordered());
        }
    }
}
