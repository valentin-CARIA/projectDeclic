namespace DeclicGUI
{
    partial class SupprimerClient
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
            this.retourSupression = new System.Windows.Forms.Button();
            this.validationSupression = new System.Windows.Forms.Button();
            this.labelSuppression = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retourSupression
            // 
            this.retourSupression.Location = new System.Drawing.Point(378, 139);
            this.retourSupression.Margin = new System.Windows.Forms.Padding(4);
            this.retourSupression.Name = "retourSupression";
            this.retourSupression.Size = new System.Drawing.Size(100, 28);
            this.retourSupression.TabIndex = 5;
            this.retourSupression.Text = "Retour";
            this.retourSupression.UseVisualStyleBackColor = true;
            this.retourSupression.Click += new System.EventHandler(this.retourSupression_Click);
            // 
            // validationSupression
            // 
            this.validationSupression.Location = new System.Drawing.Point(183, 139);
            this.validationSupression.Margin = new System.Windows.Forms.Padding(4);
            this.validationSupression.Name = "validationSupression";
            this.validationSupression.Size = new System.Drawing.Size(100, 28);
            this.validationSupression.TabIndex = 4;
            this.validationSupression.Text = "Oui";
            this.validationSupression.UseVisualStyleBackColor = true;
            this.validationSupression.Click += new System.EventHandler(this.validationSupression_Click);
            // 
            // labelSuppression
            // 
            this.labelSuppression.AutoSize = true;
            this.labelSuppression.Location = new System.Drawing.Point(179, 96);
            this.labelSuppression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuppression.Name = "labelSuppression";
            this.labelSuppression.Size = new System.Drawing.Size(44, 16);
            this.labelSuppression.TabIndex = 3;
            this.labelSuppression.Text = "label1";
            // 
            // SupprimerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 263);
            this.Controls.Add(this.retourSupression);
            this.Controls.Add(this.validationSupression);
            this.Controls.Add(this.labelSuppression);
            this.Name = "SupprimerClient";
            this.Text = "SupprimerClient";
            this.Load += new System.EventHandler(this.SupprimerClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retourSupression;
        private System.Windows.Forms.Button validationSupression;
        private System.Windows.Forms.Label labelSuppression;
    }
}