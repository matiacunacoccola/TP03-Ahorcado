using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3_Ahorcado.Models;

namespace TP3_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PalabrasAhorcado PalabrasAhorcado=new PalabrasAhorcado();
        ViewBag.palabra = PalabrasAhorcado.obtenerPalabra();
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
