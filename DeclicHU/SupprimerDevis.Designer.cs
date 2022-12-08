namespace DeclicGUI
{
    partial class SupprimerDevis
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
            this.labelSuppression = new System.Windows.Forms.Label();
            this.validationSupression = new System.Windows.Forms.Button();
            this.retourSupression = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSuppression
            // 
            this.labelSuppression.AutoSize = true;
            this.labelSuppression.Location = new System.Drawing.Point(111, 64);
            this.labelSuppression.Name = "labelSuppression";
            this.labelSuppression.Size = new System.Drawing.Size(41, 13);
            this.labelSuppression.TabIndex = 0;
            this.labelSuppression.Text = "label1 :";
            this.labelSuppression.Click += new System.EventHandler(this.labelSuppression_Click);
            // 
            // validationSupression
            // 
            this.validationSupression.Location = new System.Drawing.Point(114, 109);
            this.validationSupression.Name = "validationSupression";
            this.validationSupression.Size = new System.Drawing.Size(75, 23);
            this.validationSupression.TabIndex = 1;
            this.validationSupression.Text = "Oui";
            this.validationSupression.UseVisualStyleBackColor = true;
            this.validationSupression.Click += new System.EventHandler(this.validationSupression_Click);
            // 
            // retourSupression
            // 
            this.retourSupression.Location = new System.Drawing.Point(259, 109);
            this.retourSupression.Name = "retourSupression";
            this.retourSupression.Size = new System.Drawing.Size(75, 23);
            this.retourSupression.TabIndex = 2;
            this.retourSupression.Text = "Retour";
            this.retourSupression.UseVisualStyleBackColor = true;
            this.retourSupression.Click += new System.EventHandler(this.retourSupression_Click);
            // 
            // SupprimerDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 205);
            this.Controls.Add(this.retourSupression);
            this.Controls.Add(this.validationSupression);
            this.Controls.Add(this.labelSuppression);
            this.Name = "SupprimerDevis";
            this.Text = "SupprimerDevis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuppression;
        private System.Windows.Forms.Button validationSupression;
        private System.Windows.Forms.Button retourSupression;
    }
}