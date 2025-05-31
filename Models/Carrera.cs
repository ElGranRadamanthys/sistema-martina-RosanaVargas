using System.ComponentModel.DataAnnotations;

namespace sistema_martina.Models
{
    public class Carrera
    {
        public int Id {get ; set;}
        public string? Nombre { get ; set;}
        [Display(Name = "Duracion en Años")]
        [Required]
        public int DuracionAnios { get ; set;}
        [Display(Name = "Titulo Obtenido")]
        [Required]
        public string TituloOtorgado { get ; set;}
        public string Modalidad { get ; set;}

    }
}
