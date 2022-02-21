using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.ProductAdmin.Controllers
{
    [Area("ProductAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
