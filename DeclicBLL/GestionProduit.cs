using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;
using DeclicBLL;
using DeclicDAL;

namespace DeclicBLL
{
    public class GestionProduit
    {
        public static List<Produit> ListerProduits()
        {
            return ProduitDAO.ListerProduits();
        }
        public static bool VerifProduit(int id)
        {
            return ProduitDAO.VerifProduit(id);
        }
        public static int SupprimerProduit(int id)
        {
            return ProduitDAO.SupprimerProduit(id);
        }

        public static void AjouterProduit(Produit produit)
        {
            ProduitDAO.AjouterProduit(produit);
        }

        public static void ModifierProduit(Produit produit)
        {
            ProduitDAO.ModifierProduit(produit);
        }
    }
}
