using PortafolioJR.Models;

namespace PortafolioJR.Services
{
    public interface IRepositorioProyectos1
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos1
    {

        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() { new ProyectoDTO {
                Titulo = "Vagabundos Urban Shop",
                Descripcion = "Sistema de ventas e inventario, que consume servicios webs desarrollados en Java.",
                ImagenUrl="/css/images/vagabundosPrincipal.JPG",
                Link = "https://github.com/beto519/TiendaVagabundosUrbanShop"
            },  new ProyectoDTO {
                Titulo = "Overcrowded",
                Descripcion = "Sistema de reportes mediante un mapa de la localidad de Guaymas Sonora.",
                ImagenUrl="/css/images/OvercrowdedMapa.JPG",
                Link = "https://github.com/beto519/Overcrowded"
            },  new ProyectoDTO {
                Titulo = "Sutspes",
                Descripcion = "Sistema para niños con sindrome para la facilitacion de sus tutores.",
                ImagenUrl="/css/images/SutspesInicio.jpeg",
                Link = "https://github.com/beto519/SUTSPESisw"
            },  new ProyectoDTO {
                Titulo = "Lets Teach",
                Descripcion = "Pagina web de red escolar para el aprendizaje y retroalimentacion de alumnos.",
                ImagenUrl="/css/images/InicioLetsTeach.jpg",
                Link = "https://github.com/beto519/LetsTeach"
            },  new ProyectoDTO {
                Titulo = "Gestion de problemas",
                Descripcion = "Sistema de control de reportes de una empresa maquiladora, generando reportes de los problemas que se puedan frecuentar.",
                ImagenUrl="/css/images/GestionProblemasInicio.jpg",
                Link = "https://github.com/beto519/Gestion-de-problemas"
            },new ProyectoDTO {
                Titulo = "Estado de cuenta",
                Descripcion = "Sistema manejo de presupuesto que te permite controla tus gastos y generar un reporte en excel, ademas mostrar como un evento en un calendario con la libreria full calendar.",
                ImagenUrl="/css/images/EstadoCuenta.jpg",
                Link = "https://estadocuenta20221024.azurewebsites.net/Usuarios/Login"
            }
            };
        }

    }
}
