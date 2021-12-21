using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using CoreBlog.Base;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class BlogController : BaseController
    {
        IBlogService _blogService;
        ICategoryService _categoryService;
        BlogValidator blogValidator = new BlogValidator();

        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(_blogService.FetchCategory());
        }

        public IActionResult Detail(int id)
        {   
            return View(_blogService.Get(id));
        }

        public IActionResult List()
        {
            return View(_blogService.FetchCategoryByWriter(1));
        }

        [HttpGet]
        public IActionResult Add()
        {
            Category();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Blog p)
        {
            ValidationResult validationResult = blogValidator.Validate(p);
            if (validationResult.IsValid)
            {
                p.IsActive = true;
                p.CreateDate = DateTime.Now;
                p.WriterId = Id;
                _blogService.Add(p);
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                Category();
                return View(p);
            }
        }

        public IActionResult Delete(int id)
        {
            _blogService.Delete(Get(id));
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category();
            return View(_blogService.Get(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, Blog p)
        {
            var key = Get(id);
            ValidationResult validationResult = blogValidator.Validate(p);
            if (validationResult.IsValid)
            {
                p.WriterId = key.WriterId;
                p.CreateDate = key.CreateDate;
                _blogService.Update(p);
                return RedirectToAction("List");
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

        public Blog Get(int id)
        {
            return _blogService.Get(id);
        }

        public void Category()
        {
            List<SelectListItem> category = (from x in _categoryService.List()
                                             select new SelectListItem
                                             {

                                                 Text = x.Name,
                                                 Value = x.CategoryId.ToString(),
                                             }).ToList();
            ViewBag.Category = category;
        }
    }
}
