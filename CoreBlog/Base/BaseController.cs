using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreBlog.Base
{
    public class BaseController : Controller
    {
        public int Id { get; set; }
        public string Mail { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value;
            Id = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value);
        }
    }
}
