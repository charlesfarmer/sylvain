namespace InterfaceAdmin
{
    partial class FormMain
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tablessControl1 = new InterfaceAdmin.TablessControl();
			this.tabProfesseur = new System.Windows.Forms.TabPage();
			this.tabCours = new System.Windows.Forms.TabPage();
			this.tabEtudiant = new System.Windows.Forms.TabPage();
			this.tabAdministration = new System.Windows.Forms.TabPage();
			this.btnProfesseur = new System.Windows.Forms.Button();
			this.btnEtudiant = new System.Windows.Forms.Button();
			this.btnCours = new System.Windows.Forms.Button();
			this.btnAdministration = new System.Windows.Forms.Button();
			this.btnQuitter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tablessControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnEtudiant);
			this.splitContainer1.Panel1.Controls.Add(this.btnQuitter);
			this.splitContainer1.Panel1.Controls.Add(this.btnCours);
			this.splitContainer1.Panel1.Controls.Add(this.btnAdministration);
			this.splitContainer1.Panel1.Controls.Add(this.btnProfesseur);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tablessControl1);
			this.splitContainer1.Size = new System.Drawing.Size(879, 586);
			this.splitContainer1.SplitterDistance = 136;
			this.splitContainer1.TabIndex = 0;
			// 
			// tablessControl1
			// 
			this.tablessControl1.Controls.Add(this.tabProfesseur);
			this.tablessControl1.Controls.Add(this.tabCours);
			this.tablessControl1.Controls.Add(this.tabEtudiant);
			this.tablessControl1.Controls.Add(this.tabAdministration);
			this.tablessControl1.Location = new System.Drawing.Point(4, 4);
			this.tablessControl1.Name = "tablessControl1";
			this.tablessControl1.SelectedIndex = 0;
			this.tablessControl1.Size = new System.Drawing.Size(735, 579);
			this.tablessControl1.TabIndex = 0;
			// 
			// tabProfesseur
			// 
			this.tabProfesseur.Location = new System.Drawing.Point(4, 22);
			this.tabProfesseur.Name = "tabProfesseur";
			this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
			this.tabProfesseur.Size = new System.Drawing.Size(727, 553);
			this.tabProfesseur.TabIndex = 0;
			this.tabProfesseur.Text = "tabProfesseur";
			this.tabProfesseur.UseVisualStyleBackColor = true;
			// 
			// tabCours
			// 
			this.tabCours.Location = new System.Drawing.Point(4, 22);
			this.tabCours.Name = "tabCours";
			this.tabCours.Padding = new System.Windows.Forms.Padding(3);
			this.tabCours.Size = new System.Drawing.Size(727, 553);
			this.tabCours.TabIndex = 1;
			this.tabCours.Text = "tabCours";
			this.tabCours.UseVisualStyleBackColor = true;
			// 
			// tabEtudiant
			// 
			this.tabEtudiant.Location = new System.Drawing.Point(4, 22);
			this.tabEtudiant.Name = "tabEtudiant";
			this.tabEtudiant.Padding = new System.Windows.Forms.Padding(3);
			this.tabEtudiant.Size = new System.Drawing.Size(727, 553);
			this.tabEtudiant.TabIndex = 2;
			this.tabEtudiant.Text = "tabEtudiant";
			this.tabEtudiant.UseVisualStyleBackColor = true;
			// 
			// tabAdministration
			// 
			this.tabAdministration.Location = new System.Drawing.Point(4, 22);
			this.tabAdministration.Name = "tabAdministration";
			this.tabAdministration.Padding = new System.Windows.Forms.Padding(3);
			this.tabAdministration.Size = new System.Drawing.Size(727, 553);
			this.tabAdministration.TabIndex = 3;
			this.tabAdministration.Text = "tabAdministration";
			this.tabAdministration.UseVisualStyleBackColor = true;
			// 
			// btnProfesseur
			// 
			this.btnProfesseur.Location = new System.Drawing.Point(4, 12);
			this.btnProfesseur.Name = "btnProfesseur";
			this.btnProfesseur.Size = new System.Drawing.Size(129, 93);
			this.btnProfesseur.TabIndex = 0;
			this.btnProfesseur.Text = "Module Professeur";
			this.btnProfesseur.UseVisualStyleBackColor = true;
			// 
			// btnEtudiant
			// 
			this.btnEtudiant.Location = new System.Drawing.Point(4, 111);
			this.btnEtudiant.Name = "btnEtudiant";
			this.btnEtudiant.Size = new System.Drawing.Size(129, 93);
			this.btnEtudiant.TabIndex = 1;
			this.btnEtudiant.Text = "Module Étudiant";
			this.btnEtudiant.UseVisualStyleBackColor = true;
			// 
			// btnCours
			// 
			this.btnCours.Location = new System.Drawing.Point(4, 210);
			this.btnCours.Name = "btnCours";
			this.btnCours.Size = new System.Drawing.Size(129, 93);
			this.btnCours.TabIndex = 3;
			this.btnCours.Text = "Module Cours";
			this.btnCours.UseVisualStyleBackColor = true;
			// 
			// btnAdministration
			// 
			this.btnAdministration.Location = new System.Drawing.Point(4, 309);
			this.btnAdministration.Name = "btnAdministration";
			this.btnAdministration.Size = new System.Drawing.Size(129, 93);
			this.btnAdministration.TabIndex = 2;
			this.btnAdministration.Text = "Administration";
			this.btnAdministration.UseVisualStyleBackColor = true;
			// 
			// btnQuitter
			// 
			this.btnQuitter.Location = new System.Drawing.Point(4, 481);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(129, 93);
			this.btnQuitter.TabIndex = 5;
			this.btnQuitter.Text = "Quitter";
			this.btnQuitter.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 586);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tablessControl1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private TablessControl tablessControl1;
		private System.Windows.Forms.TabPage tabProfesseur;
		private System.Windows.Forms.TabPage tabCours;
		private System.Windows.Forms.TabPage tabEtudiant;
		private System.Windows.Forms.TabPage tabAdministration;
		private System.Windows.Forms.Button btnEtudiant;
		private System.Windows.Forms.Button btnQuitter;
		private System.Windows.Forms.Button btnCours;
		private System.Windows.Forms.Button btnAdministration;
		private System.Windows.Forms.Button btnProfesseur;
    }
}