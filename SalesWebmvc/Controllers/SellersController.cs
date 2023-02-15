using Microsoft.AspNetCore.Mvc;

namespace SalesWebmvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
