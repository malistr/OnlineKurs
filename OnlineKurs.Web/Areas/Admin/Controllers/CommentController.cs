using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class CommentController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
