using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ControllerBase : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
