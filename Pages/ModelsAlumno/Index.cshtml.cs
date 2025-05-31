using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sistema_martina.Data;
using sistema_martina.Pages.Alumnos;

namespace sistema_martina.Pages.ModelsAlumno
{
    public class IndexModel : PageModel
    {
        public List<Alumno> Alumnos { get; set; }
        public void OnGet()
        {
            Alumnos = DatosCompartidos.Alumnos;
        }
    }
}
