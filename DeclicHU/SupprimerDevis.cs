using DeclicBLL;
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
    public partial class SupprimerDevis : Form
    {
        public SupprimerDevis(int id)
        {
            InitializeComponent();
            this.id = id;
            labelSuppression.Text = "Voulez-vous vraiment supprimer le devis" + id + " ?";
            if (GestionDevis.VerifDevis(id) != true)
            {
                labelSuppression.Text = "Erreur: le devis est relié à une ou des instances de COMMANDER";
                validationSupression.Enabled = false;
            }
        }
        int id { get; set; }

        private void retourSupression_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validationSupression_Click(object sender, EventArgs e)
        {
            GestionDevis.SupprimerDevis(id);
            this.Close();
        }
        private void SupprimerProduit_Load(object sender, EventArgs e)
        {

        }

        private void labelSuppression_Click(object sender, EventArgs e)
        {

        }
    }
}
