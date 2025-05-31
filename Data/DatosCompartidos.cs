using sistema_martina.Models;
using sistema_martina.Pages.Alumnos;
namespace sistema_martina.Data
{
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new();
        public static List<Alumno> Alumnos { get; set; } = new();

        public static int ObtenerNuevoId()
        {
            ultimoId++;
            return ultimoId;
        }

    }
}
