using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlog.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        WriterValidator writerValidator = new WriterValidator();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Profile()
        {
            return View(writerManager.Get(1));
        }

        [HttpPost]
        public IActionResult Profile(IFormFile formFile, Writer p)
        {
            ProfileImage profileImage = new ProfileImage();
            ValidationResult validationResult = writerValidator.Validate(p);
            if (validationResult.IsValid)
            {
                profileImage.Profile(formFile, out string fileName);
                var key = writerManager.Get(p.WriterId);
                p.IsActive = key.IsActive;
                p.CreateDate = key.CreateDate;
                writerManager.Update(p);
                return RedirectToAction("Profile");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(p);
            }
        }
    }
}
