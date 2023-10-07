using Microsoft.AspNetCore.Mvc;

namespace OnlineKurs.Web.Areas.Admin.Controllers
{
    public class DashboardController : ControllerBase
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
