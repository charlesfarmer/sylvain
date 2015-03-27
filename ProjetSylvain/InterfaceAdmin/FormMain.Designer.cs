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
			this.btnEtudiant = new System.Windows.Forms.Button();
			this.btnQuitter = new System.Windows.Forms.Button();
			this.btnCours = new System.Windows.Forms.Button();
			this.btnAdministration = new System.Windows.Forms.Button();
			this.btnProfesseur = new System.Windows.Forms.Button();
			this.tablessControl1 = new InterfaceAdmin.TablessControl();
			this.tabProfesseur = new System.Windows.Forms.TabPage();
			this.controleCoordonees2 = new ControlCoordonées.ControleCoordonees();
			this.tabCours = new System.Windows.Forms.TabPage();
			this.controleCours1 = new ControlCoordonées.ControleCours();
			this.tabEtudiant = new System.Windows.Forms.TabPage();
			this.controleCoordonees1 = new ControlCoordonées.ControleCoordonees();
			this.tabAdministration = new System.Windows.Forms.TabPage();
			this.btnSaveMod = new System.Windows.Forms.Button();
			this.listBoxAdmin = new System.Windows.Forms.ListBox();
			this.controleAdmin1 = new ControlCoordonées.ControleAdmin();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblCreateAdmin = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tablessControl1.SuspendLayout();
			this.tabProfesseur.SuspendLayout();
			this.tabCours.SuspendLayout();
			this.tabEtudiant.SuspendLayout();
			this.tabAdministration.SuspendLayout();
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
			// btnEtudiant
			// 
			this.btnEtudiant.Location = new System.Drawing.Point(4, 111);
			this.btnEtudiant.Name = "btnEtudiant";
			this.btnEtudiant.Size = new System.Drawing.Size(129, 93);
			this.btnEtudiant.TabIndex = 1;
			this.btnEtudiant.Text = "Module Étudiant";
			this.btnEtudiant.UseVisualStyleBackColor = true;
			this.btnEtudiant.Click += new System.EventHandler(this.btnEtudiant_Click);
			// 
			// btnQuitter
			// 
			this.btnQuitter.Location = new System.Drawing.Point(4, 481);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(129, 93);
			this.btnQuitter.TabIndex = 5;
			this.btnQuitter.Text = "Quitter";
			this.btnQuitter.UseVisualStyleBackColor = true;
			this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
			// 
			// btnCours
			// 
			this.btnCours.Location = new System.Drawing.Point(4, 210);
			this.btnCours.Name = "btnCours";
			this.btnCours.Size = new System.Drawing.Size(129, 93);
			this.btnCours.TabIndex = 3;
			this.btnCours.Text = "Module Cours";
			this.btnCours.UseVisualStyleBackColor = true;
			this.btnCours.Click += new System.EventHandler(this.btnCours_Click);
			// 
			// btnAdministration
			// 
			this.btnAdministration.Location = new System.Drawing.Point(4, 309);
			this.btnAdministration.Name = "btnAdministration";
			this.btnAdministration.Size = new System.Drawing.Size(129, 93);
			this.btnAdministration.TabIndex = 2;
			this.btnAdministration.Text = "Administration";
			this.btnAdministration.UseVisualStyleBackColor = true;
			this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
			// 
			// btnProfesseur
			// 
			this.btnProfesseur.Location = new System.Drawing.Point(4, 12);
			this.btnProfesseur.Name = "btnProfesseur";
			this.btnProfesseur.Size = new System.Drawing.Size(129, 93);
			this.btnProfesseur.TabIndex = 0;
			this.btnProfesseur.Text = "Module Professeur";
			this.btnProfesseur.UseVisualStyleBackColor = true;
			this.btnProfesseur.Click += new System.EventHandler(this.btnProfesseur_Click);
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
			this.tabProfesseur.Controls.Add(this.controleCoordonees2);
			this.tabProfesseur.Location = new System.Drawing.Point(4, 22);
			this.tabProfesseur.Name = "tabProfesseur";
			this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
			this.tabProfesseur.Size = new System.Drawing.Size(727, 553);
			this.tabProfesseur.TabIndex = 0;
			this.tabProfesseur.Text = "tabProfesseur";
			this.tabProfesseur.UseVisualStyleBackColor = true;
			// 
			// controleCoordonees2
			// 
			this.controleCoordonees2.Location = new System.Drawing.Point(6, 373);
			this.controleCoordonees2.Name = "controleCoordonees2";
			this.controleCoordonees2.Size = new System.Drawing.Size(323, 174);
			this.controleCoordonees2.TabIndex = 0;
			this.controleCoordonees2.TxtAdresse = null;
			this.controleCoordonees2.TxtNom = null;
			this.controleCoordonees2.TxtPrenom = null;
			this.controleCoordonees2.TxtTelephone = null;
			// 
			// tabCours
			// 
			this.tabCours.Controls.Add(this.controleCours1);
			this.tabCours.Location = new System.Drawing.Point(4, 22);
			this.tabCours.Name = "tabCours";
			this.tabCours.Padding = new System.Windows.Forms.Padding(3);
			this.tabCours.Size = new System.Drawing.Size(727, 553);
			this.tabCours.TabIndex = 1;
			this.tabCours.Text = "tabCours";
			this.tabCours.UseVisualStyleBackColor = true;
			// 
			// controleCours1
			// 
			this.controleCours1.Location = new System.Drawing.Point(6, 344);
			this.controleCours1.Name = "controleCours1";
			this.controleCours1.Size = new System.Drawing.Size(259, 203);
			this.controleCours1.TabIndex = 0;
			// 
			// tabEtudiant
			// 
			this.tabEtudiant.Controls.Add(this.controleCoordonees1);
			this.tabEtudiant.Location = new System.Drawing.Point(4, 22);
			this.tabEtudiant.Name = "tabEtudiant";
			this.tabEtudiant.Padding = new System.Windows.Forms.Padding(3);
			this.tabEtudiant.Size = new System.Drawing.Size(727, 553);
			this.tabEtudiant.TabIndex = 2;
			this.tabEtudiant.Text = "tabEtudiant";
			this.tabEtudiant.UseVisualStyleBackColor = true;
			// 
			// controleCoordonees1
			// 
			this.controleCoordonees1.Location = new System.Drawing.Point(6, 381);
			this.controleCoordonees1.Name = "controleCoordonees1";
			this.controleCoordonees1.Size = new System.Drawing.Size(315, 166);
			this.controleCoordonees1.TabIndex = 0;
			this.controleCoordonees1.TxtAdresse = null;
			this.controleCoordonees1.TxtNom = null;
			this.controleCoordonees1.TxtPrenom = null;
			this.controleCoordonees1.TxtTelephone = null;
			// 
			// tabAdministration
			// 
			this.tabAdministration.Controls.Add(this.btnSaveMod);
			this.tabAdministration.Controls.Add(this.listBoxAdmin);
			this.tabAdministration.Controls.Add(this.controleAdmin1);
			this.tabAdministration.Controls.Add(this.btnCreate);
			this.tabAdministration.Controls.Add(this.lblCreateAdmin);
			this.tabAdministration.Location = new System.Drawing.Point(4, 22);
			this.tabAdministration.Name = "tabAdministration";
			this.tabAdministration.Padding = new System.Windows.Forms.Padding(3);
			this.tabAdministration.Size = new System.Drawing.Size(727, 553);
			this.tabAdministration.TabIndex = 3;
			this.tabAdministration.Text = "tabAdministration";
			this.tabAdministration.UseVisualStyleBackColor = true;
			// 
			// btnSaveMod
			// 
			this.btnSaveMod.Location = new System.Drawing.Point(335, 455);
			this.btnSaveMod.Name = "btnSaveMod";
			this.btnSaveMod.Size = new System.Drawing.Size(106, 36);
			this.btnSaveMod.TabIndex = 5;
			this.btnSaveMod.Text = "Save Mod.";
			this.btnSaveMod.UseVisualStyleBackColor = true;
			// 
			// listBoxAdmin
			// 
			this.listBoxAdmin.FormattingEnabled = true;
			this.listBoxAdmin.Location = new System.Drawing.Point(16, 4);
			this.listBoxAdmin.Name = "listBoxAdmin";
			this.listBoxAdmin.Size = new System.Drawing.Size(560, 121);
			this.listBoxAdmin.TabIndex = 4;
			// 
			// controleAdmin1
			// 
			this.controleAdmin1.Location = new System.Drawing.Point(3, 346);
			this.controleAdmin1.Name = "controleAdmin1";
			this.controleAdmin1.Size = new System.Drawing.Size(318, 202);
			this.controleAdmin1.TabIndex = 3;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(335, 511);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(106, 36);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			// 
			// lblCreateAdmin
			// 
			this.lblCreateAdmin.AutoSize = true;
			this.lblCreateAdmin.Location = new System.Drawing.Point(130, 323);
			this.lblCreateAdmin.Name = "lblCreateAdmin";
			this.lblCreateAdmin.Size = new System.Drawing.Size(111, 13);
			this.lblCreateAdmin.TabIndex = 1;
			this.lblCreateAdmin.Text = "Create / Mod.  Admin ";
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
			this.tabProfesseur.ResumeLayout(false);
			this.tabCours.ResumeLayout(false);
			this.tabEtudiant.ResumeLayout(false);
			this.tabAdministration.ResumeLayout(false);
			this.tabAdministration.PerformLayout();
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
		private ControlCoordonées.ControleCoordonees controleCoordonees1;
		private ControlCoordonées.ControleCoordonees controleCoordonees2;
		private ControlCoordonées.ControleCours controleCours1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label lblCreateAdmin;
		private System.Windows.Forms.ListBox listBoxAdmin;
		private ControlCoordonées.ControleAdmin controleAdmin1;
		private System.Windows.Forms.Button btnSaveMod;
    }
}