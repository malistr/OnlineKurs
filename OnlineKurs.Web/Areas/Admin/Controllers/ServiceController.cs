using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class ServiceController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
