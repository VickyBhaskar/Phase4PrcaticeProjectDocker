using Microsoft.AspNetCore.Mvc;

namespace DockerProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
