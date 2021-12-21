using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var list = _categoryService.List();
            return View(list);
        }
    }
}
