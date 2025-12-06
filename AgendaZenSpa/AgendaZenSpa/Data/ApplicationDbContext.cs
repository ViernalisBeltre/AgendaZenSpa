using AgendaZenSpa.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<Terapeuta> Terapeutas { get; set; }
    public DbSet<Cita> Citas { get; set; }
}