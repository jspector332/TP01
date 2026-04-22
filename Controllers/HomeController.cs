using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    Grupo grupo = new Grupo();

    public IActionResult Index()
    {
        ViewBag.Integrantes = grupo.devolverIntegrantes();
        return View();
    }
    public IActionResult SelectIntegrante(int dni){
        Dictionary<int,Integrante> dic = grupo.devolverIntegrantes();
        if(dic.ContainsKey(dni)){
            ViewBag.Integrante = dic[dni];
            ViewBag.Dni = dni;
            return View("InfoIntegrante");
        }
        else{
            return RedirectToAction("Index");
        }
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
