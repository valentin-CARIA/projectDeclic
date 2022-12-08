using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeclicBLL;
using DeclicBO;
using static System.Collections.Specialized.BitVector32;

namespace DeclicGUI
{
    public partial class Produit : Form
    {
        private List<Produit> liste = new List<Produit>();
        public Produit()
        {
            InitializeComponent();
            ListeProduit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GestionConnexion.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            DataGridViewTextBoxColumn colonneCode = new DataGridViewTextBoxColumn();
            colonneCode.DataPropertyName = "code";
            colonneCode.HeaderText = "CODE";

            DataGridViewTextBoxColumn colonneLibelle = new DataGridViewTextBoxColumn();
            colonneLibelle.DataPropertyName = "libelle";
            colonneLibelle.HeaderText = "LIBELLE";

            DataGridViewTextBoxColumn colonnePrixVenteHT = new DataGridViewTextBoxColumn();
            colonnePrixVenteHT.DataPropertyName = "PrixHT";
            colonnePrixVenteHT.HeaderText = "PRIX VENTE HT";

            DataGridViewTextBoxColumn colonneCategorie = new DataGridViewTextBoxColumn();
            colonneCategorie.DataPropertyName = "Categorie";
            colonneCategorie.HeaderText = "CATEGORIE";

            ListeProduit.Columns.Add(colonneCode);
            ListeProduit.Columns.Add(colonneLibelle);
            ListeProduit.Columns.Add(colonnePrixVenteHT);
            ListeProduit.Columns.Add(colonneCategorie);

            var lesCategories = new List<Categorie>();
            lesCategories = GestionCategorie.ListerCategories();

            foreach (Categorie categorie in lesCategories)
            {
                comboCategorie.Items.Add(categorie.Code + " - " + categorie.Libelle);
            }



            /*ListeProduit.ColumnHeadersVisible = true;
            colonneCode.Width = 140;
            colonneLibelle.Width = 140;
            colonnePrixHT.Width = 140;
            colonneCategorie.Width = 140;*/



            var lesProduits = new List<DeclicBO.Produit>();

            lesProduits = GestionProduit.ListerProduits();

            foreach(DeclicBO.Produit produit in lesProduits)
            {
                string cat = produit.Categorie.Code + " - " + produit.Categorie.Libelle;
                ListeProduit.Rows.Add(produit.Code, produit.Libelle, produit.PrixVente, cat);
            }

        }
        private void Produit_Load(object sender, EventArgs e)
        {
            /*Categorie = GestionCategorie.GetCategorie();*/

        }

        private void ListeProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Catégorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListeProduit_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAjtProduit_Click(object sender, EventArgs e)
        {
            int idActuel = int.Parse(ListeProduit.CurrentRow.Cells[0].Value.ToString());
            AjouterProduit AjouterProduit;
            AjouterProduit = new AjouterProduit();
            AjouterProduit.Hide();
            AjouterProduit.ShowDialog();

            ListeProduit.Rows.Clear();

            var lesProduits = new List<DeclicBO.Produit>();

            lesProduits = GestionProduit.ListerProduits();

            foreach (DeclicBO.Produit produit in lesProduits)
            {
                string cat = produit.Categorie.Code + " - " + produit.Categorie.Libelle;
                ListeProduit.Rows.Add(produit.Code, produit.Libelle, produit.PrixVente, cat);
            }
            AjouterProduit.Dispose();
        }

        private void inputLibelleProduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuppProduit_Click(object sender, EventArgs e)
        {
            int idActuel = int.Parse(ListeProduit.CurrentRow.Cells[0].Value.ToString());
            SupprimerProduit SupprimerProduit;
            SupprimerProduit = new SupprimerProduit(idActuel);
            SupprimerProduit.Hide();
            SupprimerProduit.ShowDialog();

            ListeProduit.Rows.Clear();

            var lesProduits = new List<DeclicBO.Produit>();

            lesProduits = GestionProduit.ListerProduits();

            foreach (DeclicBO.Produit produit in lesProduits)
            {
                string cat = produit.Categorie.Code + " - " + produit.Categorie.Libelle;
                ListeProduit.Rows.Add(produit.Code, produit.Libelle, produit.PrixVente, cat);
            }
            SupprimerProduit.Dispose();
        }

        private void btnModifProduit_Click(object sender, EventArgs e)
        {
            Categorie monCategorie = new Categorie(comboCategorie.SelectedIndex, "");
            monCategorie = GestionCategorie.GetCategorie(comboCategorie.SelectedIndex+1);
            DeclicBO.Produit monProduit = new DeclicBO.Produit(Int32.Parse(inputCodeProduit.Text), inputLibelleProduit.Text.ToString(), monCategorie, Double.Parse(inputPrix.Text));
            GestionProduit.ModifierProduit(monProduit);

            ListeProduit.Rows.Clear();

            var lesProduits = new List<DeclicBO.Produit>();

            lesProduits = GestionProduit.ListerProduits();

            foreach (DeclicBO.Produit produit in lesProduits)
            {
                string cat = produit.Categorie.Code + " - " + produit.Categorie.Libelle;
                ListeProduit.Rows.Add(produit.Code, produit.Libelle, produit.PrixVente, cat);
            }

        }

        private void inputPrixProduit_Click(object sender, EventArgs e)
        {

        }

        private void inputPrix_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ListeProduit_SelectionChanged_1(object sender, EventArgs e)
        {
            inputCodeProduit.Text = ListeProduit.CurrentRow.Cells[0].Value.ToString();
            inputLibelleProduit.Text = ListeProduit.CurrentRow.Cells[1].Value.ToString();
            inputPrix.Text = ListeProduit.CurrentRow.Cells[2].Value.ToString();
            comboCategorie.SelectedItem = ListeProduit.CurrentRow.Cells[3].Value.ToString();
            var lesCategories = new List<Categorie>();
            lesCategories = GestionCategorie.ListerCategories();
            /*foreach (Categorie categorie in lesCategories)
            {
                if (categorie.Code == Int32.Parse(ListeProduit.CurrentRow.Cells[3].Value.ToString())){

                    comboCategorie.SelectedIndex = categorie.Code;

                }
            }*/
        }

        private void comboCategorie_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Produit_Load_1(object sender, EventArgs e)
        {

        }

        private void inputPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputCodeProduit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
