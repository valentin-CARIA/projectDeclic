using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;

namespace DeclicBO
{
    public class Client
    {
        private int code;
        private string nom;
        private string tel;
        private string fax;
        private string email;
        private string adresseFact;
        private string villeFact;
        private string CpFact;
        private string adresseLivr;
        private string villeLivr;
        private string CpLivr;


        public Client(int code, string nom, string tel, string fax, string email, string adresseFact, string villeFact, string CpFact, string adresseLivr,
            string villeLivr, string CpLivr)
        {
            this.Code = code;
            this.Nom = nom;
            this.Tel = tel;
            this.Fax = fax;
            this.email = email;
            this.AdresseFact = adresseFact;
            this.VilleFact = villeFact;
            this.CpFact1 = CpFact;
            this.AdresseLivr = adresseLivr;
            this.VilleLivr = villeLivr;
            this.CpLivr1 = CpLivr;


        }

        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public string AdresseFact { get => adresseFact; set => adresseFact = value; }
        public string VilleFact { get => villeFact; set => villeFact = value; }
        public string CpFact1 { get => CpFact; set => CpFact = value; }
        public string AdresseLivr { get => adresseLivr; set => adresseLivr = value; }
        public string VilleLivr { get => villeLivr; set => villeLivr = value; }
        public string CpLivr1 { get => CpLivr; set => CpLivr = value; }

    }
}