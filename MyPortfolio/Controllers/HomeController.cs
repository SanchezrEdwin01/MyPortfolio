using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			var proyects = GetProjectsDTO().Take(3).ToList();
			var model = new HomeIndexViewModel() { Projects = proyects };
			return View(model);
		}

		private List<ProjectDTO> GetProjectsDTO()
		{
			return new List<ProjectDTO>() {
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
			};
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
