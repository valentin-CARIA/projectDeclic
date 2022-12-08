using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeclicBLL;
using DeclicBO;

namespace DeclicGUI
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            GestionConnexion.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnConnection_Click(object sender, EventArgs e)
        {

            Utilisateur unUtilisateur = new Utilisateur(LoginTxt.Text, PasswordTxt.Text);
            bool Valide = GestionConnexion.VerifierUtilisateur(unUtilisateur);
            if (Valide)
            {
                Accueil accueil = new Accueil();
                accueil.ShowDialog();
                this.Close();
            }
            else
            {
                erreurConnexion.Text = "Erreur: Identifiant ou Mot de Passe incorrect";
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
