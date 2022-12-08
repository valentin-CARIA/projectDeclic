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
    public partial class Client : Form
    {
        private List<Client> liste = new List<Client>();
        public Client()
        {
            InitializeComponent();
            ListeClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GestionConnexion.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            DataGridViewTextBoxColumn colonneCode = new DataGridViewTextBoxColumn();
            colonneCode.DataPropertyName = "cli_code";
            colonneCode.HeaderText = "Code";

            DataGridViewTextBoxColumn colonneNom = new DataGridViewTextBoxColumn();
            colonneNom.DataPropertyName = "cli_nom";
            colonneNom.HeaderText = "Nom";

            DataGridViewTextBoxColumn colonneTel = new DataGridViewTextBoxColumn();
            colonneTel.DataPropertyName = "cli_telephone";
            colonneTel.HeaderText = "Téléphone";

            DataGridViewTextBoxColumn colonneFax = new DataGridViewTextBoxColumn();
            colonneFax.DataPropertyName = "cli_fax";
            colonneFax.HeaderText = "Fax";

            DataGridViewTextBoxColumn colonneMail = new DataGridViewTextBoxColumn();
            colonneMail.DataPropertyName = "cli_adresse_mail";
            colonneMail.HeaderText = "Email";

            DataGridViewTextBoxColumn colonneAdresseFact = new DataGridViewTextBoxColumn();
            colonneAdresseFact.DataPropertyName = "cli_facturation_adresse";
            colonneAdresseFact.HeaderText = "Adresse Fact";

            DataGridViewTextBoxColumn colonneVilleFact = new DataGridViewTextBoxColumn();
            colonneVilleFact.DataPropertyName = "cli_facturation_ville";
            colonneVilleFact.HeaderText = "Ville Fact";

            DataGridViewTextBoxColumn colonneCPFact = new DataGridViewTextBoxColumn();
            colonneCPFact.DataPropertyName = "cli_facturation_cp";
            colonneCPFact.HeaderText = "CP Fact";
            
            DataGridViewTextBoxColumn colonneAdresseLivr = new DataGridViewTextBoxColumn();
            colonneAdresseLivr.DataPropertyName = "cli_livraison_adresse";
            colonneAdresseLivr.HeaderText = "Adresse Livr";

            DataGridViewTextBoxColumn colonneVilleLivr = new DataGridViewTextBoxColumn();
            colonneVilleLivr.DataPropertyName = "cli_livraison_ville";
            colonneVilleLivr.HeaderText = "Ville Livr";

            DataGridViewTextBoxColumn colonneCPLivr = new DataGridViewTextBoxColumn();
            colonneCPLivr.DataPropertyName = "cli_livraison_cp";
            colonneCPLivr.HeaderText = "CP Livr";

            ListeClient.Columns.Add(colonneCode);
            ListeClient.Columns.Add(colonneNom);
            ListeClient.Columns.Add(colonneAdresseFact);
            ListeClient.Columns.Add(colonneVilleFact);
            ListeClient.Columns.Add(colonneCPFact);
            ListeClient.Columns.Add(colonneAdresseLivr);
            ListeClient.Columns.Add(colonneVilleLivr);
            ListeClient.Columns.Add(colonneCPLivr);
            ListeClient.Columns.Add(colonneTel);
            ListeClient.Columns.Add(colonneFax);
            ListeClient.Columns.Add(colonneMail);


            var lesClient = new List<DeclicBO.Client>();
            lesClient = GestionClient.ListerClients();

            foreach (DeclicBO.Client client in lesClient)
            {
                ListeClient.Rows.Add(client.Code, client.Nom,client.AdresseFact, client.VilleFact, 
                    client.CpFact1, client.AdresseLivr, client.VilleLivr, client.CpLivr1, client.Tel, client.Fax, client.Email);
            }
        }

        private void ListeClient_SelectionChanged(object sender, EventArgs e)
        {
            inputCode.Text = ListeClient.CurrentRow.Cells[0].Value.ToString();
            inputNom.Text = ListeClient.CurrentRow.Cells[1].Value.ToString();
            inputAdresseFact.Text = ListeClient.CurrentRow.Cells[2].Value.ToString();
            inputVilleFact.Text = ListeClient.CurrentRow.Cells[3].Value.ToString();
            inputCPFact.Text = ListeClient.CurrentRow.Cells[4].Value.ToString();
            inputAdresseLivr.Text = ListeClient.CurrentRow.Cells[5].Value.ToString();
            inputVilleLivr.Text = ListeClient.CurrentRow.Cells[6].Value.ToString();
            inputCPLivr.Text = ListeClient.CurrentRow.Cells[7].Value.ToString();
            inputTel.Text = ListeClient.CurrentRow.Cells[8].Value.ToString();
            inputFax.Text = ListeClient.CurrentRow.Cells[9].Value.ToString();
            inputEmail.Text = ListeClient.CurrentRow.Cells[10].Value.ToString();


        }

        private void ListeClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjt_Click(object sender, EventArgs e)
        {
            int idActuel = int.Parse(ListeClient.CurrentRow.Cells[0].Value.ToString());
            AjouterClient AjouterClient;
            AjouterClient = new AjouterClient();
            AjouterClient.Hide();
            AjouterClient.ShowDialog();

            ListeClient.Rows.Clear();

            var lesClients = new List<DeclicBO.Client>();

            lesClients = GestionClient.ListerClients();

            foreach (DeclicBO.Client client in lesClients)
            {
                ListeClient.Rows.Add(client.Code, client.Nom, client.AdresseFact, client.VilleFact, client.CpFact1, client.AdresseLivr,
                    client.VilleLivr, client.CpLivr1, client.Tel, client.Fax, client.Email);
            }
            AjouterClient.Dispose();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            int idActuel = int.Parse(ListeClient.CurrentRow.Cells[0].Value.ToString());
            SupprimerClient SupprimerClient;
            SupprimerClient = new SupprimerClient(idActuel);
            SupprimerClient.Hide();
            SupprimerClient.ShowDialog();

            ListeClient.Rows.Clear();

            var lesClients = new List<DeclicBO.Client>();

            lesClients = GestionClient.ListerClients();

            foreach (DeclicBO.Client client in lesClients)
            {
                ListeClient.Rows.Add(client.Code, client.Nom, client.Tel, client.Fax, client.Email, client.AdresseFact, 
                    client.VilleFact, client.CpFact1, client.AdresseLivr, client.VilleLivr, client.CpLivr1);
            }
            SupprimerClient.Dispose();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            DeclicBO.Client monclient = new DeclicBO.Client(Int32.Parse(inputCode.Text),inputNom.Text.ToString(), inputTel.Text.ToString(),
                inputFax.Text.ToString(), inputEmail.Text.ToString(),inputAdresseFact.Text.ToString(), inputVilleFact.Text.ToString(), 
                inputCPFact.Text.ToString(), inputAdresseLivr.Text.ToString(), inputVilleLivr.Text.ToString(), inputCPLivr.Text.ToString());
            GestionClient.ModifierClient(monclient);

            ListeClient.Rows.Clear();

            var lesClient = new List<DeclicBO.Client>();

            lesClient = GestionClient.ListerClients();

            foreach (DeclicBO.Client client in lesClient)
            {
                ListeClient.Rows.Add(client.Code, client.Nom, client.Tel, client.Fax, client.Email, client.AdresseFact, client.VilleFact, 
                    client.CpFact1, client.AdresseLivr, client.VilleLivr, client.CpLivr1);
            }
        }

        private void inputAdresseLivr_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputCPFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void inputCPLivr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void inputTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void inputFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
