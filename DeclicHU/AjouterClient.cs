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
    public partial class AjouterClient : Form
    {
        public AjouterClient()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DeclicBO.Client monclient = new DeclicBO.Client(0, inputNom.Text.ToString(), inputAdresseFact.Text.ToString(), inputVilleFact.Text.ToString(), inputCPFact.Text.ToString(),
            inputAdresseLivr.Text.ToString(), inputVilleLivr.Text.ToString(), inputCPLivr.Text.ToString(), inputTel.Text.ToString(),
            inputFax.Text.ToString(), inputEmail.Text.ToString());
            DeclicBLL.GestionClient.AjouterClient(monclient);
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void inputCPFact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
