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
    public partial class SupprimerClient : Form
    {
        public SupprimerClient(int id)
        {
            InitializeComponent();
            this.id = id;
            labelSuppression.Text = "Voulez-vous vraiment supprimer le client" + id + " ?";
            if (DeclicBLL.GestionClient.VerifClient(id) != true)
            {
                labelSuppression.Text = "Erreur: le produit est relié à une ou des instances de DEVIS";
                validationSupression.Enabled = false;
            }

        }
        int id { get; set; }

        private void SupprimerClient_Load(object sender, EventArgs e)
        {

        }

        private void validationSupression_Click(object sender, EventArgs e)
        {
            DeclicBLL.GestionClient.SupprimerClient(id);
            this.Close();
        }

        private void retourSupression_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
