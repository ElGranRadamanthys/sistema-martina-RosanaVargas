using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sistema_martina.Data;
using sistema_martina.Models;

namespace sistema_martina.Pages.Carreras
{
    public class IndexModel : PageModel
    {
        public List<Carrera> Carreras { get; set; }
        public void OnGet()
        {
            Carreras = DatosCompartidos.Carreras;
        }
    }
}
