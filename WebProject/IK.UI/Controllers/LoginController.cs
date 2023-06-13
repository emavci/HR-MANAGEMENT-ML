using IK.Domain.Concrete.Sys;
using IK.Persistence.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IK.UI.Controllers
{
    public class LoginController : Controller
    {
        IKContext _context;
		//EFSysUserDal efu;
		//SysUserManager umg;

		public LoginController(IKContext context)
		{
			_context = context;
			//efu = new EFSysUserDal(context);
			//umg = new SysUserManager(efu);
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Index()
		{
			ClaimsPrincipal claimUser = HttpContext.User;

			if (claimUser.Identity.IsAuthenticated)
			{
				return RedirectToAction("Index", "Home");
			}

			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(Sys_User p)
		{
			var user = _context.Sys_Users.FirstOrDefault(x => x.Username == p.Username &&
				x.Password == p.Password);

			if (user != null)
			{
				var claims = new List<Claim>
				{
				new Claim(ClaimTypes.Name, p.Username)
				};

				var userid = new ClaimsIdentity(claims, "Login");
				ClaimsPrincipal principal = new ClaimsPrincipal(userid);

				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Home");
			}
            return RedirectToAction("Index", "Home");
        }

		[Authorize]
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Index", "Login");
		}

	}
}