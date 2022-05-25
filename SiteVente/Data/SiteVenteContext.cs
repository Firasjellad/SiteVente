using Microsoft.EntityFrameworkCore;
using SiteVente.Models;

namespace SiteVente.Data
{
    public class SiteVenteContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public SiteVenteContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fjellad.BFI-PROD\Documents\Projet.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produit>().ToTable("Produit");
            modelBuilder.Entity<Client>().ToTable("Client");

        }
    }
}
