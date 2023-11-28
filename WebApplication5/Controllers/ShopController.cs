using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication4.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult SingleProduct()
		{
			var model=new ShopSingleProductVM();
			model.CurrentDate = DateTime.Now;
			return View(model);
		}
	}
}
