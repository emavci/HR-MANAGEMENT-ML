using Microsoft.AspNetCore.Mvc;

namespace IK.UI.Controllers
{
    public class PersonVisaController : Controller
    {
        public IActionResult VisaList()
        {
            ViewBag.InitData = "";
            return View();
        }
    }
}
