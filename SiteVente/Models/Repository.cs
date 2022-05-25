using Microsoft.EntityFrameworkCore;
using SiteVente.Data;

namespace SiteVente.Models
{
    public class Repository
    {
        private SiteVenteContext _dbContext = null;

        public Repository(SiteVenteContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Produit> GetProduits()
        {
            return _dbContext.Produits.ToList();
        }
        public Produit GetProduitByName(string nom)
        {
            return _dbContext.Produits.FirstOrDefault(x => x.Nom == nom);
        }
        public void AddProduit(Produit produit)
        {
            _dbContext.Produits.Add(produit);
            _dbContext.SaveChanges();
        }

        public void UpdateProduit(Produit produit)
        {          
            try
            {
                _dbContext.Update(produit);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
        }


        public void DeletProduit(string nom)
        {
            var produit = _dbContext.Produits.FirstOrDefault(x => x.Nom == nom);
            _dbContext.Produits.Remove(produit);
            _dbContext.SaveChanges();
        }

        public List<Client> GetClients()
        {
            return _dbContext.Clients.ToList();
        }
        public Client GetClientByName(string nom)
        {
            return _dbContext.Clients.FirstOrDefault(x => x.Nom == nom);
        }
        public void AddClient(Client Client)
        {
            _dbContext.Clients.Add(Client);
            _dbContext.SaveChanges();
        }

        public void UpdateClient(Client Client)
        {
            try
            {
                _dbContext.Update(Client);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public void DeletClient(string nom)
        {
            var Client = _dbContext.Clients.FirstOrDefault(x => x.Nom == nom);
            _dbContext.Clients.Remove(Client);
            _dbContext.SaveChanges();
        }

    }
}
