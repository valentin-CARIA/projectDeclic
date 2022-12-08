using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;
using DeclicDAL;
using DeclicBLL;
using BCrypt;
using BCrypt.Net;
using System.Xml.Serialization;

namespace DeclicBLL
{
    public class GestionConnexion
    {
        private static GestionConnexion uneGestionConnexion;

        public static GestionConnexion GetGestionConnexion()
        {
            if (uneGestionConnexion == null)
            {
                uneGestionConnexion = new GestionConnexion();
            }
            return uneGestionConnexion;
        }

        public static bool VerifierUtilisateur(Utilisateur unUtilisateur)
        {
            return UtilisateurDAO.VerifierUtilisateur(unUtilisateur);

        }

        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
    }
}
