using Microsoft.AspNetCore.Mvc;

namespace newgeneration.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
