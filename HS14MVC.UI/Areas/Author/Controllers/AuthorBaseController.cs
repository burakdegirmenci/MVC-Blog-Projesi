using HS14MVC.UI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HS14MVC.UI.Areas.Author.Controllers
{
    [Area("Author")]
    [Authorize(Roles ="Author")]
    public class AuthorBaseController : BaseController
    {
        
    }
}
