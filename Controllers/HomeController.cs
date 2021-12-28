using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase3MVC.Models;

namespace Clase3MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<NomyApe> _NomyApes;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _NomyApes = new List<NomyApe>();
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult NomyApe()
    {
        
        _NomyApes.Add(new NomyApe(1,"Nicolas","Ochoa"));
        _NomyApes.Add(new NomyApe(2,"Alan","Gomez"));
        _NomyApes.Add(new NomyApe(3,"Name","Surname"));
        _NomyApes.Add(new NomyApe(4,"Name","Surname"));
        _NomyApes.Add(new NomyApe(5,"Name","Surname"));
        _NomyApes.Add(new NomyApe(6,"Name","Surname"));
        _NomyApes.Add(new NomyApe(7,"Name","Surname"));

        return View(_NomyApes);
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
