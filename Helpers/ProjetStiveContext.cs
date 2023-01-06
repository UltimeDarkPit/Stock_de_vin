using Microsoft.EntityFrameworkCore;

namespace ProjetStive.Helpers
{
    public class ProjetStiveContext:DbContext
    {
        //internal object societe_negosud;
        //internal object liste_de_vin;

        public DbSet<client> client { get; set; }

        public DbSet<quantite> quantite { get; set; }

        public DbSet<societe_negosud> societe_negosud { get; set; }

        public DbSet<stock> stock { get; set; }

        public DbSet<liste_de_vin> liste_de_vin { get; set; }




        public ProjetStiveContext() { }
        public ProjetStiveContext(DbContextOptions<ProjetStiveContext> options) : base(options) { }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OnModelCreatingpartial(modelBuilder);
            base.OnModelCreating(modelBuilder);

        }
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user=root;database=ProjetStive;password=mysql", ServerVersion.Parse("8.0.31-mysql"));
            }
        }
    }
}

