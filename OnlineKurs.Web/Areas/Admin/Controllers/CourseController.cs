using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
