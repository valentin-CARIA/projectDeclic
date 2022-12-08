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
    public class GestionDevis
    {
        public static List<Devis> ListerDevis()
        {
            return DevisDAO.ListerDevis();
        }
        public static bool VerifDevis(int id)
        {
            return DevisDAO.VerifDevis(id);
        }
        public static int SupprimerDevis(int id)
        {
            return DevisDAO.SupprimerDevis(id);
        }

        public static void AjouterDevis(Devis Devis)
        {
            DevisDAO.AjouterDevis(Devis);
        }

        public static void ModifierDevis(Devis Devis)
        {
            DevisDAO.ModifierDevis(Devis);
        }
    }
}
