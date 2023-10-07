using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class CategoryController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
