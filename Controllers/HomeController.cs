using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp03.Models;

namespace tp03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Empresa.PrecargarDiscos();
        ViewBag.infoEmpresa = Empresa.catalogo;
        return View();
    }
   


       
    }
