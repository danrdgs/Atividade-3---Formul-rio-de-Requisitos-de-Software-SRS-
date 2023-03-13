using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Requisitos.Models;

namespace Requisitos.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Tabela tabela1 = new Tabela (0, "VS 1.0", "Back End", "Daniel Rodrigues Santos");

        List<Tabela> listaTabela = new List<Tabela>();
        listaTabela.Add(tabela1);

        ViewBag.listaTabela = listaTabela;
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
