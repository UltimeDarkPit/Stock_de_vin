using Microsoft.EntityFrameworkCore;

namespace APIStockVin.Helpers
{
    public class stock_vin_context: DbContext
    {
        public DbSet<client> clients { get; set; }
        public DbSet<commande> commandes { get; set; }
        public DbSet<stock> Stocks { get; set; }
        public DbSet<entreprise> entreprise_De_Vente_De_Vins { get; set; }


        public stock_vin_context() { }
        public stock_vin_context(DbContextOptions<stock_vin_context> options) : base(options) { }

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
                optionsBuilder.UseMySql("server=localhost;user=root;database=stock_vin;password=mysql", ServerVersion.Parse("8.0.31-mysql"));
            }
        }
    }
}
