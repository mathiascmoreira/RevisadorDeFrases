using System.Data.Entity;

namespace RevisadorDeFrase.Modelos
{
    public class RevisadorFraseContext : DbContext
    {
        public RevisadorFraseContext()
            :base("RevisadorDeFrases")
        { }

        public DbSet<Texto> Textos { get; set; }
        public DbSet<Frase> Frases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Texto>().ToTable(nameof(Texto));
            modelBuilder.Entity<Frase>().ToTable(nameof(Frase));
        }
    }
}
