using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class CourseController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
