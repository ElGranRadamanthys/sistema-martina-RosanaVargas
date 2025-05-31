﻿using System.ComponentModel.DataAnnotations;

namespace sistema_martina.Pages.Alumnos
{
    public class Alumno
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        [Required]
        public string Apellido { get; set; }
        [Display(Name = "DNI")]
        [Required]
        public int Dni { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [Required]
        public string FechaNacimiento { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
    }
}
