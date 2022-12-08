namespace DeclicGUI
{
    partial class Auth
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
            this.components = new System.ComponentModel.Container();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.BtnConnection = new System.Windows.Forms.Button();
            this.erreurConnexion = new System.Windows.Forms.Label();
            this.btnDeco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTxt
            // 
            this.LoginTxt.Location = new System.Drawing.Point(316, 121);
            this.LoginTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(163, 22);
            this.LoginTxt.TabIndex = 0;
            this.LoginTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginTxt.TextChanged += new System.EventHandler(this.LoginTxt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(316, 174);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(163, 22);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(361, 102);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(79, 17);
            this.LoginLbl.TabIndex = 3;
            this.LoginLbl.Text = "Utilisateur :";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(352, 154);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(101, 17);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Mot de passe :";
            // 
            // BtnConnection
            // 
            this.BtnConnection.Location = new System.Drawing.Point(340, 226);
            this.BtnConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConnection.Name = "BtnConnection";
            this.BtnConnection.Size = new System.Drawing.Size(115, 30);
            this.BtnConnection.TabIndex = 5;
            this.BtnConnection.Text = "Connexion";
            this.BtnConnection.UseVisualStyleBackColor = true;
            this.BtnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // erreurConnexion
            // 
            this.erreurConnexion.AutoSize = true;
            this.erreurConnexion.Location = new System.Drawing.Point(257, 306);
            this.erreurConnexion.Name = "erreurConnexion";
            this.erreurConnexion.Size = new System.Drawing.Size(0, 17);
            this.erreurConnexion.TabIndex = 6;
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(358, 261);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(75, 23);
            this.btnDeco.TabIndex = 7;
            this.btnDeco.Text = "Quitter";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.erreurConnexion);
            this.Controls.Add(this.BtnConnection);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.LoginTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Auth";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button BtnConnection;
        private System.Windows.Forms.Label erreurConnexion;
        private System.Windows.Forms.Button btnDeco;
    }
}

