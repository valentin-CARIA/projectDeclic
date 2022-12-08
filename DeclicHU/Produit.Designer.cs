namespace DeclicGUI
{
    partial class Produit
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
            this.inputCodeProduit = new System.Windows.Forms.TextBox();
            this.inputLibelleProduit = new System.Windows.Forms.TextBox();
            this.inputPrix = new System.Windows.Forms.TextBox();
            this.btnModifProduit = new System.Windows.Forms.Button();
            this.CodeProduit = new System.Windows.Forms.Label();
            this.LibelleProduit = new System.Windows.Forms.Label();
            this.inputPrixProduit = new System.Windows.Forms.Label();
            this.btnSuppProduit = new System.Windows.Forms.Button();
            this.CatProduit = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAjtProduit = new System.Windows.Forms.Button();
            this.comboCategorie = new System.Windows.Forms.ComboBox();
            this.produitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListeProduit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCodeProduit
            // 
            this.inputCodeProduit.Location = new System.Drawing.Point(659, 164);
            this.inputCodeProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCodeProduit.Name = "inputCodeProduit";
            this.inputCodeProduit.ReadOnly = true;
            this.inputCodeProduit.Size = new System.Drawing.Size(100, 22);
            this.inputCodeProduit.TabIndex = 1;
            this.inputCodeProduit.TextChanged += new System.EventHandler(this.inputCodeProduit_TextChanged);
            this.inputCodeProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCategorie_KeyPress);
            // 
            // inputLibelleProduit
            // 
            this.inputLibelleProduit.Location = new System.Drawing.Point(775, 164);
            this.inputLibelleProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputLibelleProduit.Name = "inputLibelleProduit";
            this.inputLibelleProduit.Size = new System.Drawing.Size(100, 22);
            this.inputLibelleProduit.TabIndex = 2;
            this.inputLibelleProduit.TextChanged += new System.EventHandler(this.inputLibelleProduit_TextChanged);
            this.inputLibelleProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCategorie_KeyPress);
            // 
            // inputPrix
            // 
            this.inputPrix.Location = new System.Drawing.Point(775, 286);
            this.inputPrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPrix.Name = "inputPrix";
            this.inputPrix.Size = new System.Drawing.Size(100, 22);
            this.inputPrix.TabIndex = 3;
            this.inputPrix.TextChanged += new System.EventHandler(this.inputPrix_TextChanged);
            this.inputPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCategorie_KeyPress);
            // 
            // btnModifProduit
            // 
            this.btnModifProduit.Location = new System.Drawing.Point(645, 329);
            this.btnModifProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifProduit.Name = "btnModifProduit";
            this.btnModifProduit.Size = new System.Drawing.Size(88, 23);
            this.btnModifProduit.TabIndex = 5;
            this.btnModifProduit.Text = "Modifier";
            this.btnModifProduit.UseVisualStyleBackColor = true;
            this.btnModifProduit.Click += new System.EventHandler(this.btnModifProduit_Click);
            // 
            // CodeProduit
            // 
            this.CodeProduit.AutoSize = true;
            this.CodeProduit.Location = new System.Drawing.Point(684, 144);
            this.CodeProduit.Name = "CodeProduit";
            this.CodeProduit.Size = new System.Drawing.Size(49, 17);
            this.CodeProduit.TabIndex = 6;
            this.CodeProduit.Text = "Code :";
            // 
            // LibelleProduit
            // 
            this.LibelleProduit.AutoSize = true;
            this.LibelleProduit.Location = new System.Drawing.Point(796, 143);
            this.LibelleProduit.Name = "LibelleProduit";
            this.LibelleProduit.Size = new System.Drawing.Size(57, 17);
            this.LibelleProduit.TabIndex = 7;
            this.LibelleProduit.Text = "Libelle :";
            // 
            // inputPrixProduit
            // 
            this.inputPrixProduit.AutoSize = true;
            this.inputPrixProduit.Location = new System.Drawing.Point(656, 286);
            this.inputPrixProduit.Name = "inputPrixProduit";
            this.inputPrixProduit.Size = new System.Drawing.Size(87, 17);
            this.inputPrixProduit.TabIndex = 8;
            this.inputPrixProduit.Text = "Prix produit :";
            this.inputPrixProduit.Click += new System.EventHandler(this.inputPrixProduit_Click);
            // 
            // btnSuppProduit
            // 
            this.btnSuppProduit.Location = new System.Drawing.Point(787, 329);
            this.btnSuppProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppProduit.Name = "btnSuppProduit";
            this.btnSuppProduit.Size = new System.Drawing.Size(88, 23);
            this.btnSuppProduit.TabIndex = 9;
            this.btnSuppProduit.Text = "Supprimer";
            this.btnSuppProduit.UseVisualStyleBackColor = true;
            this.btnSuppProduit.Click += new System.EventHandler(this.btnSuppProduit_Click);
            // 
            // CatProduit
            // 
            this.CatProduit.AutoSize = true;
            this.CatProduit.Location = new System.Drawing.Point(668, 198);
            this.CatProduit.Name = "CatProduit";
            this.CatProduit.Size = new System.Drawing.Size(77, 17);
            this.CatProduit.TabIndex = 10;
            this.CatProduit.Text = "Catégorie :";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(724, 381);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click_1);
            // 
            // btnAjtProduit
            // 
            this.btnAjtProduit.Location = new System.Drawing.Point(724, 47);
            this.btnAjtProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjtProduit.Name = "btnAjtProduit";
            this.btnAjtProduit.Size = new System.Drawing.Size(83, 30);
            this.btnAjtProduit.TabIndex = 12;
            this.btnAjtProduit.Text = "Ajouter";
            this.btnAjtProduit.UseVisualStyleBackColor = true;
            this.btnAjtProduit.Click += new System.EventHandler(this.btnAjtProduit_Click);
            // 
            // comboCategorie
            // 
            this.comboCategorie.FormattingEnabled = true;
            this.comboCategorie.Location = new System.Drawing.Point(659, 217);
            this.comboCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(216, 24);
            this.comboCategorie.TabIndex = 13;
            this.comboCategorie.SelectedIndexChanged += new System.EventHandler(this.comboCategorie_SelectedIndexChanged);
            this.comboCategorie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCategorie_KeyPress);
            // 
            // produitBindingSource2
            // 
            this.produitBindingSource2.DataSource = typeof(DeclicBO.Produit);
            // 
            // produitBindingSource1
            // 
            this.produitBindingSource1.DataSource = typeof(DeclicBO.Produit);
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(DeclicBO.Produit);
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(DeclicBO.Categorie);
            // 
            // ListeProduit
            // 
            this.ListeProduit.AllowUserToAddRows = false;
            this.ListeProduit.AllowUserToDeleteRows = false;
            this.ListeProduit.AllowUserToOrderColumns = true;
            this.ListeProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeProduit.Location = new System.Drawing.Point(12, 64);
            this.ListeProduit.Name = "ListeProduit";
            this.ListeProduit.ReadOnly = true;
            this.ListeProduit.RowHeadersWidth = 51;
            this.ListeProduit.RowTemplate.Height = 24;
            this.ListeProduit.Size = new System.Drawing.Size(610, 374);
            this.ListeProduit.TabIndex = 14;
            this.ListeProduit.SelectionChanged += new System.EventHandler(this.ListeProduit_SelectionChanged_1);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.ListeProduit);
            this.Controls.Add(this.comboCategorie);
            this.Controls.Add(this.btnAjtProduit);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.CatProduit);
            this.Controls.Add(this.btnSuppProduit);
            this.Controls.Add(this.inputPrixProduit);
            this.Controls.Add(this.LibelleProduit);
            this.Controls.Add(this.CodeProduit);
            this.Controls.Add(this.btnModifProduit);
            this.Controls.Add(this.inputPrix);
            this.Controls.Add(this.inputLibelleProduit);
            this.Controls.Add(this.inputCodeProduit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboCategorie_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.BindingSource produitBindingSource1;
        private System.Windows.Forms.BindingSource produitBindingSource2;
        private System.Windows.Forms.TextBox inputCodeProduit;
        private System.Windows.Forms.TextBox inputLibelleProduit;
        private System.Windows.Forms.TextBox inputPrix;
        private System.Windows.Forms.Button btnModifProduit;
        private System.Windows.Forms.Label CodeProduit;
        private System.Windows.Forms.Label LibelleProduit;
        private System.Windows.Forms.Label inputPrixProduit;
        private System.Windows.Forms.Button btnSuppProduit;
        private System.Windows.Forms.Label CatProduit;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjtProduit;
        private System.Windows.Forms.ComboBox comboCategorie;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.DataGridView ListeProduit;
    }
}