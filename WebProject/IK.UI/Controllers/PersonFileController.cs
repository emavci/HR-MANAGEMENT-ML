using Microsoft.AspNetCore.Mvc;

namespace IK.UI.Controllers
{
    public class PersonFileController : Controller
    {
        public IActionResult FileList()
        {
            ViewBag.InitData = "";
            return View();
        }
    }
}
