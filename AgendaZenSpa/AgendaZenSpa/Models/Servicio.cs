using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AgendaZenSpa.Models
{
    public class Servicio
    {
        [Key]
        public int ServicioID { get; set; }

        [Required(ErrorMessage = "El nombre del servicio es obligatorio.")]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La duración en minutos es obligatoria.")]
        [Display(Name = "Duración (min)")]
        [Range(5, 300, ErrorMessage = "La duración debe ser entre 5 y 300 minutos.")]
        public int DuracionEnMinutos { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [DataType(DataType.Currency)]
        public decimal Costo { get; set; }

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}