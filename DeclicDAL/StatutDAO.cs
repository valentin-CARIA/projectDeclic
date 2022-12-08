using DeclicBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicDAL
{
    public class StatutDAO
    {
        private static StatutDAO unStatutDAO;

        public static StatutDAO GetunStatutDAO()
        {
            if (unStatutDAO == null)
            {
                unStatutDAO = new StatutDAO();
            }

            return unStatutDAO;
        }
        public static List<Statut> ListerStatuts()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Statut";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            var lesStatuts = new List<Statut>();

            while (monReader.Read())
            {
                int id = int.Parse(monReader["sta_code"].ToString());
                Statut Statut = new Statut(id, monReader["sta_lib"].ToString());
                lesStatuts.Add(Statut);
            }
            monReader.Close();
            maConnexion.Close();

            return lesStatuts;
        }

        public static Statut GetStatut(int idStatut)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT sta_lib FROM STATUT WHERE sta_code = @staCode";

            cmd.Parameters.AddWithValue("@staCode", idStatut);

            SqlDataReader monReader = cmd.ExecuteReader();

            Statut monStatut = new Statut(idStatut, "");

            while (monReader.Read())
            {
                monStatut.Libelle += monReader["sta_lib"].ToString();
            }

            maConnexion.Close();
            return monStatut;
        }


    }
}
