using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DeclicBO;

namespace DeclicDAL
{
    public class ProduitDAO
    {

        private static ProduitDAO unProduitDAO;

        public static ProduitDAO GetunPoduitDAO()
        {
            if (unProduitDAO == null)
            {
                unProduitDAO = new ProduitDAO();
            }

            return unProduitDAO;
        }
        public static List<Produit> ListerProduits()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT pro_code, pro_lib, pro_prix_vente_HT, cat_lib, dbo.CATEGORIE.cat_code FROM PRODUIT INNER JOIN dbo.CATEGORIE ON dbo.PRODUIT.cat_code = dbo.CATEGORIE.cat_code";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            var lesProduits = new List<Produit>();

            while (monReader.Read())
            {
                Categorie categorie = new Categorie(Convert.ToInt32(monReader["cat_code"]), monReader["cat_lib"].ToString());
                Produit produit = new Produit(Convert.ToInt32(monReader["pro_code"]), monReader["pro_lib"].ToString(), categorie, Double.Parse(monReader["pro_prix_vente_HT"].ToString()));

                lesProduits.Add(produit);
            }
            monReader.Close();
            maConnexion.Close();

            return lesProduits;
        }

        public static int SupprimerProduit(int id)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM PRODUIT WHERE pro_code = @proCode";
            cmd.Parameters.AddWithValue("@proCode", id);
            int resultat = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return resultat;

        }

        public static int AjouterProduit(Produit unProduit)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO PRODUIT (pro_lib, pro_prix_vente_HT, cat_code) VALUES (@proLib, @proPrix, @proCat)";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@proLib", unProduit.Libelle);
            cmd.Parameters.AddWithValue("@proPrix", unProduit.PrixVente);
            cmd.Parameters.AddWithValue("@proCat", unProduit.Categorie.Code);

            int resultat = cmd.ExecuteNonQuery();

            maConnexion.Close();
            return resultat;
            
        }

        public static void ModifierProduit(Produit produit)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Produit SET pro_lib = @proLib,  pro_prix_vente_HT = @proPrix,  cat_code = @proCat WHERE pro_code = @proCode";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@proLib", produit.Libelle);
            cmd.Parameters.AddWithValue("@proPrix", produit.PrixVente);
            cmd.Parameters.AddWithValue("@proCat", produit.Categorie.Code);
            cmd.Parameters.AddWithValue("@proCode", produit.Code);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }
        public static bool VerifProduit(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM COMMANDER WHERE pro_code = @proCode";

            cmd.Parameters.AddWithValue("@proCode", id);

            SqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();
            if (dataReader.HasRows)
            {
                maConnexion.Close();
                return false;
            }

            maConnexion.Close();
            return true;

        }

    }
}
