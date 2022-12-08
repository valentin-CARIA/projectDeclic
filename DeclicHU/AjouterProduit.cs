using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeclicBO;
using DeclicBLL;

namespace DeclicGUI
{
    public partial class AjouterProduit : Form
    {
        public AjouterProduit()
        {
            InitializeComponent();

            var lesCategories = new List<Categorie>();
            lesCategories = GestionCategorie.ListerCategories();

            foreach (Categorie categorie in lesCategories)
            {
                comboCategorie.Items.Add(categorie.Code + " - " + categorie.Libelle);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            {
                Categorie monCategorie = new Categorie(comboCategorie.SelectedIndex, "");
                monCategorie = GestionCategorie.GetCategorie(comboCategorie.SelectedIndex + 1);
                DeclicBO.Produit monProduit = new DeclicBO.Produit(0, boxLibelle.Text.ToString(), monCategorie, Double.Parse(boxPrix.Text));
                GestionProduit.AjouterProduit(monProduit);
                this.Close();
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AjouterProduit_Load(object sender, EventArgs e)
        {

        }

        private void boxPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
