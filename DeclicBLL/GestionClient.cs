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
    public class GestionClient
    {
        public static List<Client> ListerClients()
        {
            return ClientDAO.ListerClients();
        }
        public static void AjouterClient(Client unclient)
        {
            ClientDAO.AjouterClient(unclient);
        }
        public static int SupprimerClient(int id)
        {
            return ClientDAO.SupprimerClient(id);
        }
        public static void ModifierClient(Client client)
        {
            ClientDAO.ModifierClient(client);
        }
        public static bool VerifClient(int id)
        {
            return ClientDAO.VerifClient(id);
        }
        public static Client GetClient(int idClient)
        {
            return ClientDAO.GetClient(idClient);
        }
    }
}
