using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreBlog.Base;
using CoreBlog.Models;
using DataAccessLayer.Concrete.EntityFramework.Repositories;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class WriterController : BaseController
    {
        IWriterService _writerService;
        WriterValidator writerValidator = new WriterValidator();

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Profile()
        {
            return View(_writerService.Get(x => x.Mail == Mail));
        }

        [HttpPost]
        public IActionResult Profile(IFormFile formFile, Writer p)
        {
            ProfileImage profileImage = new ProfileImage();
            ValidationResult validationResult = writerValidator.Validate(p);
            if (validationResult.IsValid)
            {
                profileImage.Profile(formFile, out string fileName);
                var key = _writerService.Get(p.WriterId);
                p.IsActive = key.IsActive;
                p.CreateDate = key.CreateDate;
                _writerService.Update(p);
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
