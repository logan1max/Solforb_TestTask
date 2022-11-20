using Microsoft.AspNetCore.Mvc;
using Solforb_TestTask.BL.Interfaces;
using Solforb_TestTask.Models;
using System.Diagnostics;

namespace Solforb_TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProviderBL providerBL;

        public HomeController(
            ILogger<HomeController> logger,
            IProviderBL providerBL)
        {
            _logger = logger;
            this.providerBL = providerBL;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var res = providerBL.GetProviders();
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