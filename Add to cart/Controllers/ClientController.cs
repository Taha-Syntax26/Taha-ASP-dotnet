using Microsoft.AspNetCore.Mvc;

namespace Add_to_cart.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
