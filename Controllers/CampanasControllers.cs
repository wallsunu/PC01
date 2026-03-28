using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Services;
using System.Linq;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index()
        {
            var campanas = CampanaService.ObtenerCampanas();
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

