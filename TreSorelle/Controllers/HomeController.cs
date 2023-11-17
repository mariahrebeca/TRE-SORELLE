using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TreSorelle.Data;
using TreSorelle.Models;

namespace TreSorelle.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _contexto;

    public HomeController(ILogger<HomeController> logger, AppDbContext contexto)
    {
        _contexto = contexto;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult QuemSomos()
    {
        return View();
    }

    public IActionResult Cardapio()
    {
        var produtos = _contexto.Produtos.ToList();
        return View(produtos);
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
