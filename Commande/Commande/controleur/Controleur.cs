using GestionCommande.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.controleur
{
    public interface Controleur
    {

        void CreerCommande(Client client, ICollection<LigneCommande> ligneCmd);

        void AjoutClient(string nom, string prenom, string mail,ICollection<Commande>Commandes);

        void AjoutProduit(string designation, int Prix);

        ICollection<Client> GetClients();

        ICollection<Produit> GetProduits();

        ICollection<Commande> GetCommandes();
    }
}
