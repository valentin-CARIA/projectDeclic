namespace DeclicGUI
{
    partial class Accueil
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
            this.BtnClient = new System.Windows.Forms.Button();
            this.BtnProduit = new System.Windows.Forms.Button();
            this.BtnDevis = new System.Windows.Forms.Button();
            this.btnDeco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClient
            // 
            this.BtnClient.Location = new System.Drawing.Point(331, 170);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(120, 47);
            this.BtnClient.TabIndex = 0;
            this.BtnClient.Text = "Client";
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // BtnProduit
            // 
            this.BtnProduit.Location = new System.Drawing.Point(507, 170);
            this.BtnProduit.Name = "BtnProduit";
            this.BtnProduit.Size = new System.Drawing.Size(120, 47);
            this.BtnProduit.TabIndex = 1;
            this.BtnProduit.Text = "Produit";
            this.BtnProduit.UseVisualStyleBackColor = true;
            this.BtnProduit.Click += new System.EventHandler(this.BtnProduit_Click);
            // 
            // BtnDevis
            // 
            this.BtnDevis.Location = new System.Drawing.Point(149, 170);
            this.BtnDevis.Name = "BtnDevis";
            this.BtnDevis.Size = new System.Drawing.Size(120, 47);
            this.BtnDevis.TabIndex = 2;
            this.BtnDevis.Text = "Devis";
            this.BtnDevis.UseVisualStyleBackColor = true;
            this.BtnDevis.Click += new System.EventHandler(this.BtnDevis_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(331, 271);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(120, 23);
            this.btnDeco.TabIndex = 3;
            this.btnDeco.Text = "Deconnexion";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.BtnDevis);
            this.Controls.Add(this.BtnProduit);
            this.Controls.Add(this.BtnClient);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button BtnProduit;
        private System.Windows.Forms.Button BtnDevis;
        private System.Windows.Forms.Button btnDeco;
    }
}