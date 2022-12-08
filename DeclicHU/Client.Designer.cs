namespace DeclicGUI
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListeClient = new System.Windows.Forms.DataGridView();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputAdresseFact = new System.Windows.Forms.TextBox();
            this.inputVilleFact = new System.Windows.Forms.TextBox();
            this.inputCPFact = new System.Windows.Forms.TextBox();
            this.inputAdresseLivr = new System.Windows.Forms.TextBox();
            this.inputVilleLivr = new System.Windows.Forms.TextBox();
            this.inputCPLivr = new System.Windows.Forms.TextBox();
            this.inputTel = new System.Windows.Forms.TextBox();
            this.inputFax = new System.Windows.Forms.TextBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdFact = new System.Windows.Forms.Label();
            this.lblVilleFact = new System.Windows.Forms.Label();
            this.lblCPFact = new System.Windows.Forms.Label();
            this.lblAdLivr = new System.Windows.Forms.Label();
            this.lblVilleLivr = new System.Windows.Forms.Label();
            this.lblCPLivr = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnAjt = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListeClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeClient
            // 
            this.ListeClient.AllowUserToAddRows = false;
            this.ListeClient.AllowUserToDeleteRows = false;
            this.ListeClient.AllowUserToOrderColumns = true;
            this.ListeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeClient.Location = new System.Drawing.Point(12, 74);
            this.ListeClient.Name = "ListeClient";
            this.ListeClient.ReadOnly = true;
            this.ListeClient.RowHeadersWidth = 51;
            this.ListeClient.RowTemplate.Height = 24;
            this.ListeClient.Size = new System.Drawing.Size(1050, 561);
            this.ListeClient.TabIndex = 0;
            this.ListeClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeClient_CellContentClick);
            this.ListeClient.SelectionChanged += new System.EventHandler(this.ListeClient_SelectionChanged);
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(1089, 189);
            this.inputCode.Name = "inputCode";
            this.inputCode.ReadOnly = true;
            this.inputCode.Size = new System.Drawing.Size(132, 22);
            this.inputCode.TabIndex = 1;
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(1283, 189);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(132, 22);
            this.inputNom.TabIndex = 2;
            // 
            // inputAdresseFact
            // 
            this.inputAdresseFact.Location = new System.Drawing.Point(1089, 250);
            this.inputAdresseFact.Name = "inputAdresseFact";
            this.inputAdresseFact.Size = new System.Drawing.Size(132, 22);
            this.inputAdresseFact.TabIndex = 3;
            // 
            // inputVilleFact
            // 
            this.inputVilleFact.Location = new System.Drawing.Point(1089, 294);
            this.inputVilleFact.Name = "inputVilleFact";
            this.inputVilleFact.Size = new System.Drawing.Size(132, 22);
            this.inputVilleFact.TabIndex = 4;
            // 
            // inputCPFact
            // 
            this.inputCPFact.Location = new System.Drawing.Point(1089, 338);
            this.inputCPFact.MaxLength = 5;
            this.inputCPFact.Name = "inputCPFact";
            this.inputCPFact.Size = new System.Drawing.Size(132, 22);
            this.inputCPFact.TabIndex = 5;
            this.inputCPFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCPFact_KeyPress);
            // 
            // inputAdresseLivr
            // 
            this.inputAdresseLivr.Location = new System.Drawing.Point(1283, 249);
            this.inputAdresseLivr.Name = "inputAdresseLivr";
            this.inputAdresseLivr.Size = new System.Drawing.Size(132, 22);
            this.inputAdresseLivr.TabIndex = 6;
            this.inputAdresseLivr.TextChanged += new System.EventHandler(this.inputAdresseLivr_TextChanged);
            // 
            // inputVilleLivr
            // 
            this.inputVilleLivr.Location = new System.Drawing.Point(1283, 293);
            this.inputVilleLivr.Name = "inputVilleLivr";
            this.inputVilleLivr.Size = new System.Drawing.Size(132, 22);
            this.inputVilleLivr.TabIndex = 7;
            // 
            // inputCPLivr
            // 
            this.inputCPLivr.Location = new System.Drawing.Point(1283, 337);
            this.inputCPLivr.MaxLength = 5;
            this.inputCPLivr.Name = "inputCPLivr";
            this.inputCPLivr.Size = new System.Drawing.Size(132, 22);
            this.inputCPLivr.TabIndex = 8;
            this.inputCPLivr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCPLivr_KeyPress);
            // 
            // inputTel
            // 
            this.inputTel.Location = new System.Drawing.Point(1089, 404);
            this.inputTel.MaxLength = 10;
            this.inputTel.Name = "inputTel";
            this.inputTel.Size = new System.Drawing.Size(132, 22);
            this.inputTel.TabIndex = 9;
            this.inputTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTel_KeyPress);
            // 
            // inputFax
            // 
            this.inputFax.Location = new System.Drawing.Point(1283, 404);
            this.inputFax.MaxLength = 10;
            this.inputFax.Name = "inputFax";
            this.inputFax.Size = new System.Drawing.Size(132, 22);
            this.inputFax.TabIndex = 10;
            this.inputFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputFax_KeyPress);
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(1089, 450);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(132, 22);
            this.inputEmail.TabIndex = 11;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(1089, 498);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(132, 34);
            this.btnModif.TabIndex = 12;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(1283, 498);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(132, 34);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(1125, 170);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 17);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "Code :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(1324, 170);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "Nom :";
            // 
            // lblAdFact
            // 
            this.lblAdFact.AutoSize = true;
            this.lblAdFact.Location = new System.Drawing.Point(1107, 231);
            this.lblAdFact.Name = "lblAdFact";
            this.lblAdFact.Size = new System.Drawing.Size(99, 17);
            this.lblAdFact.TabIndex = 16;
            this.lblAdFact.Text = "Adresse Fact :";
            // 
            // lblVilleFact
            // 
            this.lblVilleFact.AutoSize = true;
            this.lblVilleFact.Location = new System.Drawing.Point(1116, 275);
            this.lblVilleFact.Name = "lblVilleFact";
            this.lblVilleFact.Size = new System.Drawing.Size(73, 17);
            this.lblVilleFact.TabIndex = 17;
            this.lblVilleFact.Text = "Ville Fact :";
            // 
            // lblCPFact
            // 
            this.lblCPFact.AutoSize = true;
            this.lblCPFact.Location = new System.Drawing.Point(1097, 319);
            this.lblCPFact.Name = "lblCPFact";
            this.lblCPFact.Size = new System.Drawing.Size(122, 17);
            this.lblCPFact.TabIndex = 18;
            this.lblCPFact.Text = "Code postal Fact :";
            // 
            // lblAdLivr
            // 
            this.lblAdLivr.AutoSize = true;
            this.lblAdLivr.Location = new System.Drawing.Point(1303, 230);
            this.lblAdLivr.Name = "lblAdLivr";
            this.lblAdLivr.Size = new System.Drawing.Size(95, 17);
            this.lblAdLivr.TabIndex = 19;
            this.lblAdLivr.Text = "Adresse Livr :";
            // 
            // lblVilleLivr
            // 
            this.lblVilleLivr.AutoSize = true;
            this.lblVilleLivr.Location = new System.Drawing.Point(1314, 275);
            this.lblVilleLivr.Name = "lblVilleLivr";
            this.lblVilleLivr.Size = new System.Drawing.Size(69, 17);
            this.lblVilleLivr.TabIndex = 20;
            this.lblVilleLivr.Text = "Ville Livr :";
            // 
            // lblCPLivr
            // 
            this.lblCPLivr.AutoSize = true;
            this.lblCPLivr.Location = new System.Drawing.Point(1291, 319);
            this.lblCPLivr.Name = "lblCPLivr";
            this.lblCPLivr.Size = new System.Drawing.Size(118, 17);
            this.lblCPLivr.TabIndex = 21;
            this.lblCPLivr.Text = "Code postal Livr :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(1116, 385);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(84, 17);
            this.lblTel.TabIndex = 22;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(1327, 385);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(38, 17);
            this.lblFax.TabIndex = 23;
            this.lblFax.Text = "Fax :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(1128, 433);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 17);
            this.lblMail.TabIndex = 24;
            this.lblMail.Text = "Email :";
            // 
            // btnAjt
            // 
            this.btnAjt.Location = new System.Drawing.Point(1194, 62);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(119, 40);
            this.btnAjt.TabIndex = 25;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = true;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1215, 538);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 26;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DeclicBO.Client);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 696);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCPLivr);
            this.Controls.Add(this.lblVilleLivr);
            this.Controls.Add(this.lblAdLivr);
            this.Controls.Add(this.lblCPFact);
            this.Controls.Add(this.lblVilleFact);
            this.Controls.Add(this.lblAdFact);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.inputFax);
            this.Controls.Add(this.inputTel);
            this.Controls.Add(this.inputCPLivr);
            this.Controls.Add(this.inputVilleLivr);
            this.Controls.Add(this.inputAdresseLivr);
            this.Controls.Add(this.inputCPFact);
            this.Controls.Add(this.inputVilleFact);
            this.Controls.Add(this.inputAdresseFact);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.ListeClient);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputAdresseFact;
        private System.Windows.Forms.TextBox inputVilleFact;
        private System.Windows.Forms.TextBox inputCPFact;
        private System.Windows.Forms.TextBox inputAdresseLivr;
        private System.Windows.Forms.TextBox inputVilleLivr;
        private System.Windows.Forms.TextBox inputCPLivr;
        private System.Windows.Forms.TextBox inputTel;
        private System.Windows.Forms.TextBox inputFax;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdFact;
        private System.Windows.Forms.Label lblVilleFact;
        private System.Windows.Forms.Label lblCPFact;
        private System.Windows.Forms.Label lblAdLivr;
        private System.Windows.Forms.Label lblVilleLivr;
        private System.Windows.Forms.Label lblCPLivr;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.Button btnRetour;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}