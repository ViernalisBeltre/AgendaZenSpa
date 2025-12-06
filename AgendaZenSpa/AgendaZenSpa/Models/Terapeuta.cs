using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AgendaZenSpa.Models
{
    public class Terapeuta
    {
        [Key]
        public int TerapeutaID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100)]
        public string Apellido { get; set; }

        [StringLength(150)]
        public string Especialidad { get; set; }

        // Propiedad de navegación (Relación 1-a-Muchos con Citas)
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}