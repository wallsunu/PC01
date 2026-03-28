using PortalCampanas.Models;

namespace PortalCampanas.Services
{
    public class CampanaService
    {
        public static List<Campana> ObtenerCampanas()
        {
            return new List<Campana>
            {
                new Campana {
                    Id = 1,
                    Nombre = "Cyber Electro",
                    Categoria = "Electro",
                    Estado = "Vigente",
                    Canal = "Web",
                    DescuentoPct = 20,
                    FechaInicio = DateTime.Now.AddDays(-5),
                    FechaFin = DateTime.Now.AddDays(5),
                    Descripcion = "Ofertas en productos electrónicos"
                },
                new Campana {
                    Id = 2,
                    Nombre = "Hogar Feliz",
                    Categoria = "Hogar",
                    Estado = "Próxima",
                    Canal = "Tienda",
                    DescuentoPct = 15,
                    FechaInicio = DateTime.Now.AddDays(3),
                    FechaFin = DateTime.Now.AddDays(10),
                    Descripcion = "Descuentos para el hogar"
                },
                new Campana {
                    Id = 3,
                    Nombre = "Moda Verano",
                    Categoria = "Moda",
                    Estado = "Finalizada",
                    Canal = "App",
                    DescuentoPct = 30,
                    FechaInicio = DateTime.Now.AddDays(-20),
                    FechaFin = DateTime.Now.AddDays(-10),
                    Descripcion = "Promociones en ropa de verano"
                }
            };
        }
    }
}