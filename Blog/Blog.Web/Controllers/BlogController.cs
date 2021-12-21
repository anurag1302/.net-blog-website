using Blog.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private readonly IRepository _repository;

        public BlogController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var model = _repository.GetAllPosts();
            return View();
        }
    }
}
