using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Inbox()
        {
            return View(_messageService.GetInboxListByWriter(2));
        }

        public IActionResult Details(int id)
        {
            return View(_messageService.Get(x => x.MessageId == id));
        }
    }
}
