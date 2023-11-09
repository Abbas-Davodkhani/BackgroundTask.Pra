using BackgroundTask.Pra.CT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackgroundTask.Pra.CT.Controllers
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
            return View();
        }
        // cancel process in background if cancellationRequest
        public async Task<IActionResult> Privacy(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Process started ... ");

            for (int i = 0; i < 5; i++)
            {
                _logger.LogInformation($"{i}"); 
                //cancellationToken.ThrowIfCancellationRequested();
                //if(cancellationToken.IsCancellationRequested)
                //{
                //    // do something
                //}
                await Task.Delay(1000 , cancellationToken);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}