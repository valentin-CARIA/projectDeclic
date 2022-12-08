namespace projectDeclic
{
    partial class ValidateDelete
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
            this.DeleteValidator = new System.Windows.Forms.Label();
            this.DeleteYES = new System.Windows.Forms.Button();
            this.DeleteNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteValidator
            // 
            this.DeleteValidator.AutoSize = true;
            this.DeleteValidator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeleteValidator.Cursor = System.Windows.Forms.Cursors.No;
            this.DeleteValidator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteValidator.Location = new System.Drawing.Point(106, 36);
            this.DeleteValidator.Name = "DeleteValidator";
            this.DeleteValidator.Size = new System.Drawing.Size(287, 18);
            this.DeleteValidator.TabIndex = 0;
            this.DeleteValidator.Text = "Êtes-vous sûr de vouloir supprimer ce produit ?";
            this.DeleteValidator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteYES
            // 
            this.DeleteYES.Location = new System.Drawing.Point(148, 57);
            this.DeleteYES.Name = "DeleteYES";
            this.DeleteYES.Size = new System.Drawing.Size(75, 23);
            this.DeleteYES.TabIndex = 1;
            this.DeleteYES.Text = "Oui";
            this.DeleteYES.UseVisualStyleBackColor = true;
            // 
            // DeleteNO
            // 
            this.DeleteNO.Location = new System.Drawing.Point(280, 57);
            this.DeleteNO.Name = "DeleteNO";
            this.DeleteNO.Size = new System.Drawing.Size(75, 23);
            this.DeleteNO.TabIndex = 2;
            this.DeleteNO.Text = "Non";
            this.DeleteNO.UseVisualStyleBackColor = true;
            // 
            // ValidateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 121);
            this.Controls.Add(this.DeleteNO);
            this.Controls.Add(this.DeleteYES);
            this.Controls.Add(this.DeleteValidator);
            this.Name = "ValidateDelete";
            this.Text = "ValidateDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteValidator;
        private System.Windows.Forms.Button DeleteYES;
        private System.Windows.Forms.Button DeleteNO;
    }
}