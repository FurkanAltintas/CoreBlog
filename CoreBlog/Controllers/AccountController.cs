using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlog.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
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
        public async Task<IActionResult> Login(Writer p)
        {
            if (writerManager.Login(p))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Mail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                //HttpContext.Session.SetString("username", p.Mail);
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

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Blog");
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
