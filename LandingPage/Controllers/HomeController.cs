using LandingPage.Models;
using LandingPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LandingPage.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IConstructionIdeasRepository constructionIdeasRepository;

		public HomeController(ILogger<HomeController> logger, IConstructionIdeasRepository constructionIdeasRepository)
		{
			_logger = logger;
			this.constructionIdeasRepository = constructionIdeasRepository;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Ideas()
		{
			var ideas = this.constructionIdeasRepository.GetIdeas();
			return View(ideas);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}