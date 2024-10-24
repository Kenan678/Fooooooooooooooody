using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
	public class CategoriesController : Controller
	{
		private	readonly ICategoryService _categoryService;	
		public IActionResult Index()
		{
			return View();

		}
	}
}
