using Microsoft.AspNetCore.Mvc;
using UILayer.Models;

namespace UILayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		[HttpGet]
		public IActionResult Index(int id)
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(ConfirmMailViewModel confirmMailViewModel)
		{
            return View();
        }
	}
}
