using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DeclicBO;

namespace DeclicDAL
{
    public class ClientDAO
    {

        private static ClientDAO unClientDAO;

        public static ClientDAO GetunClientDAO()
        {
            if (unClientDAO == null)
            {
                unClientDAO = new ClientDAO();
            }

            return unClientDAO;
        }
        public static List<Client> ListerClients()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM CLIENT";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            var lesClients = new List<Client>();

            while (monReader.Read())
            {
                Client client = new Client(Convert.ToInt32(monReader["cli_code"]), monReader["cli_nom"].ToString(), monReader["cli_telephone"].ToString(),
                    monReader["cli_fax"].ToString(), monReader["cli_adresse_mail"].ToString(), monReader["cli_facturation_adresse"].ToString(),
                    monReader["cli_facturation_ville"].ToString(), monReader["cli_facturation_cp"].ToString(), monReader["cli_livraison_adresse"].ToString(), 
                    monReader["cli_livraison_ville"].ToString(), monReader["cli_livraison_cp"].ToString());

                lesClients.Add(client);
            }
            monReader.Close();
            maConnexion.Close();

            return lesClients;
        }
        public static int AjouterClient(Client unclient)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO CLIENT (cli_nom, cli_facturation_adresse, cli_facturation_ville, " +
                "cli_facturation_cp, cli_livraison_adresse, cli_livraison_ville, cli_livraison_cp,cli_telephone, cli_fax, cli_adresse_mail) VALUES (@cliNom, @cliTel, @cliFax, @cli_adresse_mail, @cli_fact_ad, " +
                "@cli_fact_ville, @cli_fact_cp, @cli_livr_ad, @cli_livr_ville, @cli_livr_cp)";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@cliNom", unclient.Nom);
            cmd.Parameters.AddWithValue("@cliTel", unclient.Tel);
            cmd.Parameters.AddWithValue("@cliFax", unclient.Fax);
            cmd.Parameters.AddWithValue("@cli_adresse_mail", unclient.Email);
            cmd.Parameters.AddWithValue("@cli_fact_ad", unclient.AdresseFact);
            cmd.Parameters.AddWithValue("@cli_fact_ville", unclient.VilleFact);
            cmd.Parameters.AddWithValue("@cli_fact_cp", unclient.CpFact1);
            cmd.Parameters.AddWithValue("@cli_livr_ad", unclient.AdresseLivr);
            cmd.Parameters.AddWithValue("@cli_livr_ville", unclient.VilleLivr);
            cmd.Parameters.AddWithValue("@cli_livr_cp", unclient.CpLivr1);

            int resultat = cmd.ExecuteNonQuery();

            maConnexion.Close();
            return resultat;

        }
        public static int SupprimerClient(int id)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM CLIENT WHERE cli_code = @cliCode";
            cmd.Parameters.AddWithValue("@cliCode", id);
            int resultat = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return resultat;

        }
        public static void ModifierClient(Client client)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE CLIENT SET cli_nom = @cliNom, cli_facturation_adresse = @cliAdFact, cli_facturation_ville = @cliVilleFact," +
                "cli_facturation_cp = @cliCPFact, cli_livraison_adresse = @cliAdLivr, cli_livraison_ville = @cliVilleLivr, cli_livraison_cp = @cliCPLivr, cli_Telephone = @cliTel, cli_Fax = @cliFax, cli_adresse_mail = @cliEmail WHERE cli_code = @cliCode";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@cliCode", client.Code);
            cmd.Parameters.AddWithValue("@cliNom", client.Nom);
            cmd.Parameters.AddWithValue("@cliAdFact", client.AdresseFact);
            cmd.Parameters.AddWithValue("@cliVilleFact", client.VilleFact);
            cmd.Parameters.AddWithValue("@cliCPFact", client.CpFact1);
            cmd.Parameters.AddWithValue("@cliAdLivr", client.AdresseLivr);
            cmd.Parameters.AddWithValue("@cliVilleLivr", client.VilleLivr);
            cmd.Parameters.AddWithValue("@cliCPLivr", client.CpLivr1);
            cmd.Parameters.AddWithValue("@cliTel", client.Tel);
            cmd.Parameters.AddWithValue("@cliFax", client.Fax);
            cmd.Parameters.AddWithValue("@cliEmail", client.Email);


            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }
        public static bool VerifClient(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM DEVIS WHERE cli_code = @cliCode";

            cmd.Parameters.AddWithValue("@cliCode", id);

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
        public static Client GetClient(int idClient)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT cli_nom FROM CLIENT WHERE cli_code = @cliCode";

            cmd.Parameters.AddWithValue("@cliCode", idClient);

            SqlDataReader monReader = cmd.ExecuteReader();

            Client monClient = new Client(idClient, "","","","","","","","","","");

            while (monReader.Read())
            {
                monClient.Nom += monReader["cli_nom"].ToString();
            }

            maConnexion.Close();
            return monClient;
        }

    }
}
