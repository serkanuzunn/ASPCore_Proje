using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Proje.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
