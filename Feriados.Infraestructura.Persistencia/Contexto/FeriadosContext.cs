using Feriados.Dominio.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Feriados.Infraestructura.Persistencia.Contexto
{
    public class FeriadosContext: DbContext
    {
        public FeriadosContext(DbContextOptions<FeriadosContext> options) : base(options)
        {
        }
        public DbSet<Festivo> Festivos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Estructura
            modelBuilder.Entity<Festivo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            modelBuilder.Entity<Festivo>()
               .HasOne(e => e.TipoFestivo)
               .WithMany()
               .HasForeignKey(e => e.IdTipo);

            modelBuilder.Entity<Tipo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Tipo).IsUnique();
            });
        }
    }
}
