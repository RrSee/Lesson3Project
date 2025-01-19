using Microsoft.AspNetCore.Mvc;

namespace Lesson3.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
