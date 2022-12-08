using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;

namespace DeclicBO
{
    public class Statut
    {
        private int code;
        private string libelle;

        public Statut(int code, string libelle)
        {
            this.Code = code;
            this.Libelle = libelle;
        }

        public int Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}