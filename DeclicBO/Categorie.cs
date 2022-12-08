using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeclicBO
{
    public class Categorie
    {
        private int code;
        private string libelle;


        public Categorie(int code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;


        }

        public int Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }

    }

}