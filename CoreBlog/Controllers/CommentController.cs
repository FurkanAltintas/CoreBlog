using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class CommentController : Controller
    {
        ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public PartialViewResult List(int id)
        {
            return PartialView(_commentService.List(id));
        }

        [HttpGet]
        public PartialViewResult Add()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Add(Comment p)
        {
            _commentService.Add(p);
            return RedirectToAction("Detail", "Blog", new { id = p.BlogId });
        }
    }
}
