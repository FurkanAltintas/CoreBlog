using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlog.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        WriterValidator writerValidator = new WriterValidator();
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
            GetCity();
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer p, string city)
        {
            ValidationResult validationResult = writerValidator.Validate(p);
            if (validationResult.IsValid)
            {
                p.IsActive = true;
                writerManager.Add(p);
                return RedirectToAction("Login", "Account");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                GetCity();
            }
            return View();
        }

        public void GetCity()
        {
            List<SelectListItem> city = (from x in Cities()
                                         select new SelectListItem
                                         {
                                             Text = x,
                                             Value = x
                                         }).ToList();
            ViewBag.City = city;
        }

        public List<string> Cities()
        {
            string[] cities = new string[] { "İstanbul", "İzmir", "Ankara", "Tokat", "Amasya", "Düzce", "Eskişehir" };
            return new List<string>(cities);
        }
    }
}
