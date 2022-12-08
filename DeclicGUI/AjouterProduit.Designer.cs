namespace projectDeclic
{
    partial class AjouterProduit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textCode = new System.Windows.Forms.TextBox();
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.ListCategorie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(54, 63);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(139, 22);
            this.textCode.TabIndex = 0;
            this.textCode.Text = "Code ";
            this.textCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCode.TextChanged += new System.EventHandler(this.textCode_TextChanged);
            // 
            // textLibelle
            // 
            this.textLibelle.Location = new System.Drawing.Point(248, 63);
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(139, 22);
            this.textLibelle.TabIndex = 2;
            this.textLibelle.Text = "Libelle";
            this.textLibelle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLibelle.TextChanged += new System.EventHandler(this.textLibelle_TextChanged);
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(248, 111);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(139, 22);
            this.textPrix.TabIndex = 3;
            this.textPrix.Text = "Prix";
            this.textPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPrix.TextChanged += new System.EventHandler(this.textPrix_TextChanged);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(173, 149);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(98, 35);
            this.BtnAjouter.TabIndex = 4;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // ListCategorie
            // 
            this.ListCategorie.FormattingEnabled = true;
            this.ListCategorie.ItemHeight = 16;
            this.ListCategorie.Location = new System.Drawing.Point(54, 113);
            this.ListCategorie.Name = "ListCategorie";
            this.ListCategorie.Size = new System.Drawing.Size(139, 20);
            this.ListCategorie.TabIndex = 8;
            this.ListCategorie.SelectedIndexChanged += new System.EventHandler(this.ListCategorie_SelectedIndexChanged);
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 222);
            this.Controls.Add(this.ListCategorie);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.textLibelle);
            this.Controls.Add(this.textCode);
            this.Name = "AjouterProduit";
            this.Text = "Ajouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textLibelle;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.ListBox ListCategorie;
    }
}

