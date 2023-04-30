using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ec2_dashboard.ui.Models;

namespace ec2_dashboard.ui.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var domains = new List<DomainViewModel>
        {
            new DomainViewModel { Name = "example.com", IsRunning = true },
            new DomainViewModel { Name = "test.com", IsRunning = false },
            new DomainViewModel { Name = "dev.com", IsRunning = true }
        };

        return View(domains);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}