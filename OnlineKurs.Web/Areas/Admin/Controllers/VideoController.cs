using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class VideoController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
