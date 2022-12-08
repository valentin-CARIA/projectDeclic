using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicBO;

namespace DeclicBO
{
    public class Produit
    {
        private int code;
        private string libelle;
        private Categorie categorie;
        private Double prixVente;


        public Produit(int code, string libelle, Categorie categorie, Double prixVente)
        {
            this.Code = code;
            this.Libelle = libelle;
            this.Categorie = categorie; 
            this.PrixVente = prixVente;

        }

        public int Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public Categorie Categorie { get => categorie; set => categorie = value; }
        public Double PrixVente { get => prixVente; set => prixVente = value; }

    }
    
}

