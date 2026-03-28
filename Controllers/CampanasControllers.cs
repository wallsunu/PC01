using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Services;
using System.Linq;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index(string categoria, string estado)
        {
            var campanas = CampanaService.ObtenerCampanas();

            if (!string.IsNullOrEmpty(categoria))
                campanas = campanas.Where(c => c.Categoria == categoria).ToList();

            if (!string.IsNullOrEmpty(estado))
                campanas = campanas.Where(c => c.Estado == estado).ToList();

            return View(campanas);
        }
        public IActionResult Detalle(int id)
        {
            var campana = CampanaService.ObtenerCampanas()
                .FirstOrDefault(c => c.Id == id);

            return View(campana);
        }
        public IActionResult Resumen()
        {
            var campanas = CampanaService.ObtenerCampanas();

            var total = campanas.Count;
            var vigentes = campanas.Count(c => c.Estado == "Vigente");
            var proximas = campanas.Count(c => c.Estado == "Próxima");
            var promedio = campanas.Average(c => c.DescuentoPct);

            var porCanal = campanas
                .GroupBy(c => c.Canal)
                .Select(g => new { Canal = g.Key, Cantidad = g.Count() })
                .ToList();

            ViewBag.Total = total;
            ViewBag.Vigentes = vigentes;
            ViewBag.Proximas = proximas;
            ViewBag.Promedio = promedio;
            ViewBag.PorCanal = porCanal;

            return View();
        }
    }
    
}

