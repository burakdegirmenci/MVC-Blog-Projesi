using Microsoft.AspNetCore.Mvc;

namespace HS14MVC.UI.Areas.Author.Controllers
{
    public class HomeController : AuthorBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
