using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        BlogValidator blogValidator = new BlogValidator();
        public IActionResult Index()
        {
            return View(blogManager.FetchCategory());
        }

        public IActionResult Detail(int id)
        {
            return View(blogManager.GetById(id));
        }

        public IActionResult List()
        {
            return View(blogManager.FetchCategoryByWriter(1));
        }

        [HttpGet]
        public IActionResult Add()
        {
            //ViewBag.Category = new SelectList(categoryManager.List(), "Id", "Name");
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
                p.WriterId = 1;
                blogManager.Add(p);
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
            blogManager.Delete(Get(id));
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category();
            return View(blogManager.GetById(id));
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
                blogManager.Update(p);
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
            return blogManager.GetById(id);
        }

        public void Category()
        {
            List<SelectListItem> category = (from x in categoryManager.List()
                                             select new SelectListItem
                                             {

                                                 Text = x.Name,
                                                 Value = x.CategoryId.ToString(),
                                             }).ToList();
            ViewBag.Category = category;
        }
    }
}
