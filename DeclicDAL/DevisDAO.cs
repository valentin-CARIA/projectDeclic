using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DeclicBO;

namespace DeclicDAL
{
    public class DevisDAO
    {

        private static DevisDAO unDevisDAO;

        public static DevisDAO GetunPoduitDAO()
        {
            if (unDevisDAO == null)
            {
                unDevisDAO = new DevisDAO();
            }

            return unDevisDAO;
        }

        public static List<Devis> ListerDevis() 
         {
             // Connexion à la BD
             SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

             // Requette sql
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = maConnexion;
             cmd.CommandText = "SELECT devis_code, devis_date, devis_taux_TVA, dbo.DEVIS.cli_code, cli_nom, dbo.DEVIS.sta_code, sta_lib FROM DEVIS INNER JOIN dbo.CLIENT ON dbo.CLIENT.cli_code = dbo.DEVIS.cli_code JOIN dbo.STATUT ON dbo.STATUT.sta_code = dbo.DEVIS.sta_code";

             // Lecture des données
             SqlDataReader monReader = cmd.ExecuteReader();

             var lesDevis = new List<Devis>();

             while (monReader.Read())
             {
                Client client = new Client(Convert.ToInt32(monReader["cli_code"]), monReader["cli_nom"].ToString(), "", "", "", "", "", "", "", "", "");
                Statut statut = new Statut(Convert.ToInt32(monReader["sta_code"]), monReader["sta_lib"].ToString());
                Devis Devis = new Devis(Convert.ToInt32(monReader["devis_code"]), Convert.ToDateTime(monReader["devis_date"].ToString()), client, statut, Double.Parse(monReader["devis_taux_TVA"].ToString()));

                lesDevis.Add(Devis);
             }
             monReader.Close();
             maConnexion.Close();

             return lesDevis;
        }
        

        public static bool VerifDevis(int id) {
            return true;
        }

        public static int SupprimerDevis(int id)
        {
             SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM DEVIS WHERE devis_code = @devisCode";
            cmd.Parameters.AddWithValue("@devisCode", id);
            int resultat = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return resultat;
            
        }

        public static void AjouterDevis(Devis devis)
        {

        }

        public static void ModifierDevis(Devis devis)
        {

        }


    }
}
