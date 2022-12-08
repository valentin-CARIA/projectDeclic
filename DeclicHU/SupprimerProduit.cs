using DeclicBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeclicGUI
{
    public partial class SupprimerProduit : Form
    {
        public SupprimerProduit(int id)
        {
            InitializeComponent();
            this.id = id;
            labelSuppression.Text = "Voulez-vous vraiment supprimer le produit" + id + " ?";
            if (GestionProduit.VerifProduit(id) != true)
            {
                labelSuppression.Text = "Erreur: le produit est relié à une ou des instances de COMMANDER";
                validationSupression.Enabled = false;
            }
        }

        int id { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void validationSupression_Click_1(object sender, EventArgs e)
        {
            GestionProduit.SupprimerProduit(id);
            this.Close();
        }

        private void retourSupression_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupprimerProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
