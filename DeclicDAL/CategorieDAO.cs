using DeclicBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicDAL
{
    public class CategorieDAO
    {
        private static CategorieDAO unCategorieDAO;

        public static CategorieDAO GetunPoduitDAO()
        {
            if (unCategorieDAO == null)
            {
                unCategorieDAO = new CategorieDAO();
            }

            return unCategorieDAO;
        }
        public static List<Categorie> ListerCategories()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM CATEGORIE";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            var lesCategories = new List<Categorie>();

            while (monReader.Read())
            {
                int id = int.Parse(monReader["cat_code"].ToString());
                Categorie categorie = new Categorie(id, monReader["cat_lib"].ToString());
                lesCategories.Add(categorie);
            }
            monReader.Close();
            maConnexion.Close();

            return lesCategories;
        }

        public static Categorie GetCategorie(int idCategorie)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT cat_lib FROM CATEGORIE WHERE cat_code = @catCode";

            cmd.Parameters.AddWithValue("@catCode", idCategorie);

            SqlDataReader monReader = cmd.ExecuteReader();

            Categorie maCategorie = new Categorie(idCategorie, "");

            while (monReader.Read())
            {
                maCategorie.Libelle += monReader["cat_lib"].ToString();
            }

            maConnexion.Close();
            return maCategorie;
        }


    }
}
