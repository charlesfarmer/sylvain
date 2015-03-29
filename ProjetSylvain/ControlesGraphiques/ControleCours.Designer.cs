namespace ControlCoordonées
{
	partial class ControleCours
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblSujet = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblProfesseur = new System.Windows.Forms.Label();
            this.lblCout = new System.Windows.Forms.Label();
            this.lblDateLimite = new System.Windows.Forms.Label();
            this.txtSujet = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.dtpDateLimite = new System.Windows.Forms.DateTimePicker();
            this.cbProfesseur = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSujet
            // 
            this.lblSujet.AutoSize = true;
            this.lblSujet.Location = new System.Drawing.Point(7, 44);
            this.lblSujet.Name = "lblSujet";
            this.lblSujet.Size = new System.Drawing.Size(34, 13);
            this.lblSujet.TabIndex = 0;
            this.lblSujet.Text = "Sujet ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(7, 76);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            // 
            // lblProfesseur
            // 
            this.lblProfesseur.AutoSize = true;
            this.lblProfesseur.Location = new System.Drawing.Point(7, 141);
            this.lblProfesseur.Name = "lblProfesseur";
            this.lblProfesseur.Size = new System.Drawing.Size(57, 13);
            this.lblProfesseur.TabIndex = 2;
            this.lblProfesseur.Text = "Professeur";
            // 
            // lblCout
            // 
            this.lblCout.AutoSize = true;
            this.lblCout.Location = new System.Drawing.Point(7, 108);
            this.lblCout.Name = "lblCout";
            this.lblCout.Size = new System.Drawing.Size(29, 13);
            this.lblCout.TabIndex = 3;
            this.lblCout.Text = "Cout";
            // 
            // lblDateLimite
            // 
            this.lblDateLimite.AutoSize = true;
            this.lblDateLimite.Location = new System.Drawing.Point(7, 172);
            this.lblDateLimite.Name = "lblDateLimite";
            this.lblDateLimite.Size = new System.Drawing.Size(60, 13);
            this.lblDateLimite.TabIndex = 4;
            this.lblDateLimite.Text = "Date Limite";
            // 
            // txtSujet
            // 
            this.txtSujet.Location = new System.Drawing.Point(87, 44);
            this.txtSujet.Name = "txtSujet";
            this.txtSujet.Size = new System.Drawing.Size(225, 20);
            this.txtSujet.TabIndex = 5;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(87, 76);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(225, 20);
            this.txtTitre.TabIndex = 6;
            // 
            // txtCout
            // 
            this.txtCout.Location = new System.Drawing.Point(87, 108);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(225, 20);
            this.txtCout.TabIndex = 8;
            // 
            // dtpDateLimite
            // 
            this.dtpDateLimite.Location = new System.Drawing.Point(87, 172);
            this.dtpDateLimite.Name = "dtpDateLimite";
            this.dtpDateLimite.Size = new System.Drawing.Size(200, 20);
            this.dtpDateLimite.TabIndex = 9;
            // 
            // cbProfesseur
            // 
            this.cbProfesseur.FormattingEnabled = true;
            this.cbProfesseur.Location = new System.Drawing.Point(87, 141);
            this.cbProfesseur.Name = "cbProfesseur";
            this.cbProfesseur.Size = new System.Drawing.Size(121, 21);
            this.cbProfesseur.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 11);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 12;
            // 
            // ControleCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbProfesseur);
            this.Controls.Add(this.dtpDateLimite);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.txtSujet);
            this.Controls.Add(this.lblDateLimite);
            this.Controls.Add(this.lblCout);
            this.Controls.Add(this.lblProfesseur);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSujet);
            this.Name = "ControleCours";
            this.Size = new System.Drawing.Size(327, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSujet;
		private System.Windows.Forms.Label lblTitre;
		private System.Windows.Forms.Label lblProfesseur;
		private System.Windows.Forms.Label lblCout;
		private System.Windows.Forms.Label lblDateLimite;
		private System.Windows.Forms.TextBox txtSujet;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.DateTimePicker dtpDateLimite;
        private System.Windows.Forms.ComboBox cbProfesseur;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBox4;
	}
}
