using System.ComponentModel.DataAnnotations.Schema;

public class Terapeuta
{
    public int TerapeutaID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Especialidad { get; set; }
    public ICollection<Cita> Citas { get; set; }
}

public class Paciente
{
    public int PacienteID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public ICollection<Cita> Citas { get; set; }
}

public class Servicio
{
    public int ServicioID { get; set; }
    public string Nombre { get; set; }
    public int DuracionEnMinutos { get; set; }
    public decimal Costo { get; set; }
    public ICollection<Cita> Citas { get; set; }
}

public class Cita
{
    public int ID { get; set; }
    public int PacienteID { get; set; }
    public int ServicioID { get; set; }
    public int TerapeutaID { get; set; }

    public DateTime FechaCita { get; set; }
    public TimeSpan HoraCita { get; set; }
    public Paciente Paciente { get; set; }
    public Servicio Servicio { get; set; }
    public Terapeuta Terapeuta { get; set; }

    [NotMapped]
    public string Duracion { get; set; }

    [NotMapped]
    public string DiasHorasRestantes { get; set; }

    [NotMapped]
    public string Estado { get; set; }
}