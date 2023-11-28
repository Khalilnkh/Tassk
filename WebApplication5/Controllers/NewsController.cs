using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
