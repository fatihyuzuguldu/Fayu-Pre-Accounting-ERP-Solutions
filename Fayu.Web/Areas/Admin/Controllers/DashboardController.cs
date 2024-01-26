using Fayu.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fayu.Web.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles = SD.Role_Admin)]
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
