using Microsoft.EntityFrameworkCore;
using AgendaZenSpa.Models;

namespace AgendaZenSpa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; } = default!;
        public DbSet<Servicio> Servicios { get; set; } = default!;
        public DbSet<Terapeuta> Terapeutas { get; set; } = default!;
        public DbSet<Cita> Citas { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}