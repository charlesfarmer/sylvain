namespace InterfaceAdmin
{
    partial class FormLogin
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
            this.controleLogin1 = new ControlCoordonées.ControleLogin();
            this.SuspendLayout();
            // 
            // controleLogin1
            // 
            this.controleLogin1.Location = new System.Drawing.Point(84, 41);
            this.controleLogin1.Name = "controleLogin1";
            this.controleLogin1.Size = new System.Drawing.Size(223, 80);
            this.controleLogin1.TabIndex = 0;
            this.controleLogin1.TxtIdentifiant = null;
            this.controleLogin1.TxtPassword = null;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 160);
            this.Controls.Add(this.controleLogin1);
            this.Name = "FormLogin";
            this.Text = "Connexion au système SCHOOLADMIN3000";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCoordonées.ControleLogin controleLogin1;
    }
}

