using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sistema_martina.Data;
using sistema_martina.Models;

namespace sistema_martina.Pages.Carreras
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public Carrera Carrera { get; set; }

        //public static List<Carrera> listaCarreras = new List<Carrera>();



        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Carrera.Id = DatosCompartidos.ObtenerNuevoId();
            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("Index");
        }
    }
}
