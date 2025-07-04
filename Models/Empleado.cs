using System;
using System.ComponentModel.DataAnnotations;

namespace EmpleadosApp.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        [Display(Name = "Área")]
        public string Area { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }

        public bool Activo { get; set; }
    }
}
