using BusinessLayer.Abstract;
using CoreBlog.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Writer
{
    public class Messages : ViewComponent
    {
        IMessageService _messageService;

        public Messages(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_messageService.GetInboxListByWriter((Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value))));
        }
    }
}
