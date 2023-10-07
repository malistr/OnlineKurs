using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class TeacherController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
