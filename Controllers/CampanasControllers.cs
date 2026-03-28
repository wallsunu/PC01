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
    }
    
}

