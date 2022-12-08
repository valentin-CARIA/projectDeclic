using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;

namespace DeclicBO
{
    public class Devis
    {
        private int code;
        private DateTime date;
        private Client client;
        private Statut statut;
        private double tauxTVA;

        public Devis(int code, DateTime date, Client client, Statut statut, double tauxTVA)
        {
            this.Code = code;
            this.Date = date;
            this.Client = client;
            this.Statut = statut;
            this.TauxTVA = tauxTVA;

        }

        public int Code { get => code; set => code = value; }
        public DateTime Date { get => date; set => date = value; }
        public Client Client { get => client; set => client = value; }
        public Statut Statut { get => statut; set => statut = value; }
        public double TauxTVA { get => tauxTVA; set => tauxTVA = value; }
    }
}