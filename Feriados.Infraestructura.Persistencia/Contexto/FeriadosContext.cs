using Feriados.Dominio.Entidades;

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
            modelBuilder.Entity<Festivo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            modelBuilder.Entity<Festivo>()
               .HasOne(e => e.Tipo)
               .WithMany()
               .HasForeignKey(e => e.Id);

            modelBuilder.Entity<Tipo>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });
        }
    }
}
