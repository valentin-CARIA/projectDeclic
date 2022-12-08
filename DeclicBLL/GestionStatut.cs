using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;
using DeclicDAL;

namespace DeclicBLL
{
    public class GestionStatut
    {
        private static GestionStatut myGestionStatut;

        public static GestionStatut GetGestionStatut()
        {
            if (myGestionStatut == null)
            {
                myGestionStatut = new GestionStatut();
            }
            return myGestionStatut;
        }
        /*
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }*/

        public static List<Statut> ListerStatuts()
        {
            return StatutDAO.ListerStatuts();
        }

        public static Statut GetStatut(int idStatut)
        {
            return StatutDAO.GetStatut(idStatut);
        }


    }
}
