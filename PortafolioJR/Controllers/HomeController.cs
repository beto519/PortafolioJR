using Microsoft.AspNetCore.Mvc;
using PortafolioJR.Models;
using PortafolioJR.Services;
using System.Diagnostics;

namespace PortafolioJR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos1 repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos1 repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos().ToList();
            var modelo = new HomeIndexViewModl()
            {
                Proyectos = proyectos,

            };
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}