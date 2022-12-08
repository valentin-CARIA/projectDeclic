using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeclicGUI
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void BtnProduit_Click(object sender, EventArgs e)
        {
            Produit produit = new Produit();
            produit.ShowDialog();
        }

        private void BtnDevis_Click(object sender, EventArgs e)
        {
            Devis devis = new Devis();
            devis.ShowDialog();
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ShowDialog();
        }
    }
}
