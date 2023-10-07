using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class StudentController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
