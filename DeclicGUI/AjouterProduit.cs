using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeclicDAL;



namespace projectDeclic
{

    public partial class AjouterProduit : Form
    {
        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void textCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textPrix_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CATEGORIE VALUES('valeur-1', 'valeur-2')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();

        }

    }
}
