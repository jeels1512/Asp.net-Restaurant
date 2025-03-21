using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebsite.Controllers
{
    public class HomeController : Controller
    {
        // Home page
        public IActionResult Index()
        {
            return View();
        }

        // Menu page
        public IActionResult Menu()
        {
            return View();
        }

        // About page
        public IActionResult About()
        {
            return View();
        }

        // Contact page
        public IActionResult Contact()
        {
            return View();
        }
    }
}
