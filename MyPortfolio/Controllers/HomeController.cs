using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Interfaces;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IProjectsRepository projectsRepository;

		public HomeController(ILogger<HomeController> logger, IProjectsRepository projectsRepository)
		{
			_logger = logger;

			_logger.LogCritical("This is a Critical log");
			_logger.LogError("This is a Error log");
			_logger.LogWarning("This is a Warning log");
			_logger.LogInformation("This is a Information log");
			_logger.LogDebug("This is a Debug log");
			_logger.LogTrace("This is a Trace log");

			this.projectsRepository = projectsRepository;
		}

		public IActionResult Index()
		{
			var proyects = projectsRepository.GetProjectsDTO().Take(3).ToList();
			var model = new HomeIndexViewModel() { Projects = proyects };
			return View(model);
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
