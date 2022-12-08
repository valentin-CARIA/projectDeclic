using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicBO
{
    public class Utilisateur
    {

        private string pseudonyme;
        private string mdp;

        public Utilisateur(string pseudonyme, string mdp)
        {
            this.pseudonyme = pseudonyme;
            this.mdp = mdp;
        }

        public string Pseudonyme { get => pseudonyme; set => pseudonyme = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}
