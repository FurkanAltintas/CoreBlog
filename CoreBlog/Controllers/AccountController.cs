using BusinessLayer.Concrete;
using CoreBlog.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class AccountController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Writer p)
        {
            if (writerManager.Login(p))
            {
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                ViewBag.Error = "Girdiğiniz bilgiler yanlış";
                return View(p);
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            List<City> cities = new List<City>();
            cities.Add(new City()
            {
                Id = 1,
                Name = "İstanbul"
            });
            cities.Add(new City()
            {
                Id = 2,
                Name = "İzmir"
            });
            cities.Add(new City()
            {
                Id = 3,
                Name = "Ankara"
            });

            ViewBag.City = new SelectList(cities.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer p)
        {
            writerManager.Register(p);
            return RedirectToAction("Login", "Account");
        }

    }
}
