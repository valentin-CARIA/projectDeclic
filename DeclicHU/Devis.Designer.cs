namespace DeclicGUI
{
    partial class Devis
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
            this.dataGridViewDevis = new System.Windows.Forms.DataGridView();
            this.btnSupr = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTaux = new System.Windows.Forms.TextBox();
            this.boxCode = new System.Windows.Forms.TextBox();
            this.boxStatut = new System.Windows.Forms.ComboBox();
            this.boxClient = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDevis
            // 
            this.dataGridViewDevis.AllowUserToAddRows = false;
            this.dataGridViewDevis.AllowUserToDeleteRows = false;
            this.dataGridViewDevis.AllowUserToOrderColumns = true;
            this.dataGridViewDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevis.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewDevis.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDevis.Name = "dataGridViewDevis";
            this.dataGridViewDevis.ReadOnly = true;
            this.dataGridViewDevis.RowHeadersWidth = 51;
            this.dataGridViewDevis.RowTemplate.Height = 24;
            this.dataGridViewDevis.Size = new System.Drawing.Size(553, 297);
            this.dataGridViewDevis.TabIndex = 0;
            this.dataGridViewDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeDevis_CellContentClick);
            this.dataGridViewDevis.SelectionChanged += new System.EventHandler(this.dataGridViewDevis_SelectionChanged);
            // 
            // btnSupr
            // 
            this.btnSupr.Location = new System.Drawing.Point(712, 228);
            this.btnSupr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupr.Name = "btnSupr";
            this.btnSupr.Size = new System.Drawing.Size(86, 28);
            this.btnSupr.TabIndex = 1;
            this.btnSupr.Text = "Supprimer";
            this.btnSupr.UseVisualStyleBackColor = true;
            this.btnSupr.Click += new System.EventHandler(this.btnSupr_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(664, 10);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(76, 30);
            this.btnAjout.TabIndex = 2;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(664, 277);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(76, 30);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(606, 228);
            this.btnModif.Margin = new System.Windows.Forms.Padding(2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(86, 28);
            this.btnModif.TabIndex = 4;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Statut :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Taux de TVA : ";
            // 
            // boxTaux
            // 
            this.boxTaux.Location = new System.Drawing.Point(722, 73);
            this.boxTaux.Margin = new System.Windows.Forms.Padding(2);
            this.boxTaux.Name = "boxTaux";
            this.boxTaux.Size = new System.Drawing.Size(84, 20);
            this.boxTaux.TabIndex = 11;
            this.boxTaux.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTaux_KeyPress);
            // 
            // boxCode
            // 
            this.boxCode.Location = new System.Drawing.Point(595, 73);
            this.boxCode.Margin = new System.Windows.Forms.Padding(2);
            this.boxCode.Name = "boxCode";
            this.boxCode.ReadOnly = true;
            this.boxCode.Size = new System.Drawing.Size(84, 20);
            this.boxCode.TabIndex = 14;
            this.boxCode.TextChanged += new System.EventHandler(this.boxCode_TextChanged);
            // 
            // boxStatut
            // 
            this.boxStatut.FormattingEnabled = true;
            this.boxStatut.Location = new System.Drawing.Point(595, 187);
            this.boxStatut.Margin = new System.Windows.Forms.Padding(2);
            this.boxStatut.Name = "boxStatut";
            this.boxStatut.Size = new System.Drawing.Size(84, 21);
            this.boxStatut.TabIndex = 15;
            this.boxStatut.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // boxClient
            // 
            this.boxClient.FormattingEnabled = true;
            this.boxClient.Location = new System.Drawing.Point(722, 187);
            this.boxClient.Margin = new System.Windows.Forms.Padding(2);
            this.boxClient.Name = "boxClient";
            this.boxClient.Size = new System.Drawing.Size(87, 21);
            this.boxClient.TabIndex = 16;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(595, 128);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker.TabIndex = 17;
            // 
            // Devis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 366);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.boxClient);
            this.Controls.Add(this.boxStatut);
            this.Controls.Add(this.boxCode);
            this.Controls.Add(this.boxTaux);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnSupr);
            this.Controls.Add(this.dataGridViewDevis);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Devis";
            this.Text = "Devis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDevis;
        private System.Windows.Forms.Button btnSupr;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxTaux;
        private System.Windows.Forms.TextBox boxCode;
        private System.Windows.Forms.ComboBox boxStatut;
        private System.Windows.Forms.ComboBox boxClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}