using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DeclicBO;
using BCrypt;
using BCrypt.Net;
using System.Xml.Serialization;


namespace DeclicDAL
{
    public class UtilisateurDAO
    {

        private static UtilisateurDAO unUtilisateurDAO;
        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs 
        public static List<Utilisateur> GetUtilisateurs()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            
            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            Utilisateur unUtilisateur = new Utilisateur("","");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Utilisateur";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                unUtilisateur.Pseudonyme += monReader["uti_nom"].ToString();
                unUtilisateur.Mdp += monReader["uti_mdp"].ToString();
                lesUtilisateurs.Add(unUtilisateur);
            }
            // Fermeture de la connexion
            monReader.Close();
            maConnexion.Close();
            return lesUtilisateurs;
        }

        public static bool VerifierUtilisateur(Utilisateur unUtilisateur)
        {
            List<Utilisateur> Utilisateurs = new List<Utilisateur>();
            Utilisateurs = UtilisateurDAO.GetUtilisateurs();
            bool UtilisateurTrouve = false;

            foreach (Utilisateur utilisateurListe in Utilisateurs)
            {

                if (unUtilisateur.Pseudonyme == utilisateurListe.Pseudonyme)
                {

                    if (BCrypt.Net.BCrypt.Verify(unUtilisateur.Mdp, utilisateurListe.Mdp))
                    {
                        UtilisateurTrouve = true;
                        break;
                    }

                }

            }

            if (UtilisateurTrouve)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

