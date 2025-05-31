using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sistema_martina.Data;
using sistema_martina.Models;

namespace sistema_martina.Pages.Carreras
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public void OnGet(int id)
        {
            foreach (var c in DatosCompartidos.Carreras)
            {
                if (c.Id == id)
                {
                    Carrera = c;
                    break;
                    
                }
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach (var c in DatosCompartidos.Carreras)
            {
                if (c.Id == Carrera.Id) 
                {
                c.Nombre = Carrera.Nombre;
                    c.Modalidad = Carrera.Modalidad;
                    c.DuracionAnios = Carrera.DuracionAnios;
                    c.TituloOtorgado = Carrera.TituloOtorgado;
                    break;
                }
            }

            return RedirectToPage("Index");
        }
    }
}
