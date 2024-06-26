using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KhumaloCraftEmporium.Models;

namespace KhumaloCraftEmporium.Controllers;

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

   
public IActionResult About()
    {
        return View();
    }

 public IActionResult Contact()
    {
        return View();
    }

 public IActionResult Work()
    {
        return View();
    }


     public IActionResult Mug()
    {
        return View();
    }

 public IActionResult Bag()
    {
        return View();
    }

     public IActionResult Spoon()
    {
        return View();
    }

    public IActionResult Desk()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
