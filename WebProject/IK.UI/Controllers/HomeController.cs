using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Sys;
using IK.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IK.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonService _personService;

        public HomeController(ILogger<HomeController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public async Task<IActionResult> Index()
        {


            //_personService.Add(new Sys_Person
            //{
            //    CreatedAt = DateTime.Now.ToUniversalTime(),
            //    CreatedUserId = 2,
            //    PersonTypeID = 3,
            //    PersonFingerID = 4,
            //    Name = "burak1",
            //    Status = 1,
            //    SyncID = 1
            //});


            //var data = await _personService.GetAllAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}