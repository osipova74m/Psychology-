using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PsychologCore.Models;
using PsychologCore.Service;
using System.Diagnostics;

namespace PsychologCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService _articles;

        public HomeController(
            ILogger<HomeController> logger,
            IArticleService articles
            )
        {
            _logger = logger;
            _articles = articles;
        }

        public IActionResult Index()
        {
            _logger.LogInformation($"Running Index method");
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

        /// <summary>
        /// this method should display all articles from the system;
        /// articles get from service;
        /// </summary>
        public IActionResult Articles()
        {
            _logger.LogInformation($"Running Articles method..");

            var articles = _articles.GetArticles();

            return View(articles);
        }
    }
}
