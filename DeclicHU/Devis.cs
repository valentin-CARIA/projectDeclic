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
    public partial class Devis : Form
    {
        private List<Devis> liste = new List<Devis>();
        public Devis()
        {

            InitializeComponent();
            dataGridViewDevis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GestionConnexion.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            DataGridViewTextBoxColumn colonneCode = new DataGridViewTextBoxColumn();
            colonneCode.DataPropertyName = "Code";
            colonneCode.HeaderText = "CODE";

            DataGridViewTextBoxColumn colonneDate = new DataGridViewTextBoxColumn();
            colonneDate.DataPropertyName = "Date";
            colonneDate.HeaderText = "DATE";

            DataGridViewTextBoxColumn colonneTauxTVA = new DataGridViewTextBoxColumn();
            colonneTauxTVA.DataPropertyName = "TauxTVA";
            colonneTauxTVA.HeaderText = "Taux TVA";

            DataGridViewTextBoxColumn colonneClient = new DataGridViewTextBoxColumn();
            colonneClient.DataPropertyName = "Client";
            colonneClient.HeaderText = "CLIENT";

            DataGridViewTextBoxColumn colonneStatus = new DataGridViewTextBoxColumn();
            colonneStatus.DataPropertyName = "Statut";
            colonneStatus.HeaderText = "STATUT";

            dataGridViewDevis.Columns.Add(colonneCode);
            dataGridViewDevis.Columns.Add(colonneDate);
            dataGridViewDevis.Columns.Add(colonneTauxTVA);
            dataGridViewDevis.Columns.Add(colonneClient);
            dataGridViewDevis.Columns.Add(colonneStatus);

            var lesClients = new List<DeclicBO.Client>();
            lesClients = GestionClient.ListerClients();

            foreach (DeclicBO.Client client in lesClients)
            {
              boxClient.Items.Add(client.Code + " - " + client.Nom);
            }

            var lesStatuts = new List<DeclicBO.Statut>();
            lesStatuts = GestionStatut.ListerStatuts();

            foreach (DeclicBO. Statut statut in lesStatuts)
            {
                boxStatut.Items.Add(statut.Code + " - " + statut.Libelle);
            }

            var lesDevis = new List<DeclicBO.Devis>();

            lesDevis = GestionDevis.ListerDevis();

            foreach (DeclicBO.Devis devis in lesDevis)
            {
                string sta = devis.Statut.Code + " - " + devis.Statut.Libelle;
                string cli = devis.Client.Code + " - " + devis.Client.Nom;
                dataGridViewDevis.Rows.Add(devis.Code, devis.Date.ToShortDateString(), devis.TauxTVA, cli, sta);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDevis_SelectionChanged(object sender, EventArgs e)
        {
            boxCode.Text = dataGridViewDevis.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker.Text = dataGridViewDevis.CurrentRow.Cells[1].Value.ToString();
            boxTaux.Text = dataGridViewDevis.CurrentRow.Cells[2].Value.ToString();
            boxClient.SelectedItem = dataGridViewDevis.CurrentRow.Cells[3].Value.ToString();
            boxStatut.SelectedItem = dataGridViewDevis.CurrentRow.Cells[4].Value.ToString();
        }

        private void boxTaux_KeyPress(object sender, KeyPressEventArgs e)
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

        private void boxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            DeclicBO.Client monClient = new DeclicBO.Client(boxClient.SelectedIndex, "", "", "", "", "", "", "", "", "", "");
            monClient = GestionClient.GetClient(boxClient.SelectedIndex + 1);
            Statut monStatut = new Statut(boxStatut.SelectedIndex, "");
            monStatut = GestionStatut.GetStatut(boxClient.SelectedIndex + 1);
            DeclicBO.Devis monDevis = new DeclicBO.Devis(Int32.Parse(boxCode.Text), DateTime.Parse(dateTimePicker.Text), monClient, monStatut, Double.Parse(boxTaux.Text));
                GestionDevis.ModifierDevis(monDevis);

                GestionDevis.ListerDevis().Clear();

                var lesDevis = new List<DeclicBO.Devis>();

                lesDevis = GestionDevis.ListerDevis();

                foreach (DeclicBO.Devis devis in lesDevis)
                {
                    string devCli = devis.Client.Code + " - " + devis.Client.Nom;
                    string devSta = devis.Statut.Code + " - " + devis.Statut.Libelle;
                    dataGridViewDevis.Rows.Add(devis.Code, devis.Date, devis.Client, devis.Statut, devis.TauxTVA, devCli, devSta);
                }
        }

        private void btnSupr_Click(object sender, EventArgs e)
        {
            int idActuel = int.Parse(dataGridViewDevis.CurrentRow.Cells[0].Value.ToString());
            SupprimerDevis SupprimerDevis;
            SupprimerDevis = new SupprimerDevis(idActuel);
            SupprimerDevis.Hide();
            SupprimerDevis.ShowDialog();

            dataGridViewDevis.Rows.Clear();

            var lesDevis = new List<DeclicBO.Devis>();

            lesDevis = GestionDevis.ListerDevis();

            foreach (DeclicBO.Devis devis in lesDevis)
            {
                string devCli = devis.Client.Code + " - " + devis.Client.Nom;
                string devSta = devis.Statut.Code + " - " + devis.Statut.Libelle;
                dataGridViewDevis.Rows.Add(devis.Code, devis.Date, devis.Client, devis.Statut, devis.TauxTVA, devCli, devSta);
            }
            SupprimerDevis.Dispose();
            
        }

        private void ListeDevis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
