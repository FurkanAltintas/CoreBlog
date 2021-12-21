using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Footer
{
    public class FooterAbout : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IViewComponentResult Invoke()
        {
            return View(aboutManager.Get());
        }
    }
}
