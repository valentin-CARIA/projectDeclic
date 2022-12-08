using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;
using DeclicDAL;

namespace DeclicBLL
{
    public class GestionCategorie
    {
        private static GestionCategorie myGestionCategorie;

        public static GestionCategorie GetGestionCategories()
        {
            if (myGestionCategorie == null)
            {
                myGestionCategorie = new GestionCategorie();
            }
            return myGestionCategorie;
        }
        /*
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }*/

        public static List<Categorie> ListerCategories()
        {
            return CategorieDAO.ListerCategories();
        }

        public  static Categorie GetCategorie(int idCategorie)
        {
            return CategorieDAO.GetCategorie(idCategorie);
        }


    }
}
