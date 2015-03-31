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
            this.ProfesseurHoraire = new System.Windows.Forms.GroupBox();
            this.ProfesseurRecherche = new System.Windows.Forms.GroupBox();
            this.ProfesseurCoordonnees = new System.Windows.Forms.GroupBox();
            this.tabCours = new System.Windows.Forms.TabPage();
            this.tabEtudiant = new System.Windows.Forms.TabPage();
            this.EtudiantHoraire = new System.Windows.Forms.GroupBox();
            this.EtudiantRecherche = new System.Windows.Forms.GroupBox();
            this.EtudiantCoordonnees = new System.Windows.Forms.GroupBox();
            this.tabAdministration = new System.Windows.Forms.TabPage();
            this.AdminRecherche = new System.Windows.Forms.GroupBox();
            this.AdminInfo = new System.Windows.Forms.GroupBox();
            this.controleAdmin1 = new ControlCoordonées.ControleAdmin();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tablessControl1.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.tabEtudiant.SuspendLayout();
            this.tabAdministration.SuspendLayout();
            this.AdminInfo.SuspendLayout();
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
            this.tabProfesseur.Controls.Add(this.ProfesseurHoraire);
            this.tabProfesseur.Controls.Add(this.ProfesseurRecherche);
            this.tabProfesseur.Controls.Add(this.ProfesseurCoordonnees);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 22);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(727, 553);
            this.tabProfesseur.TabIndex = 0;
            this.tabProfesseur.Text = "tabProfesseur";
            this.tabProfesseur.UseVisualStyleBackColor = true;
            // 
            // ProfesseurHoraire
            // 
            this.ProfesseurHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesseurHoraire.Location = new System.Drawing.Point(369, 272);
            this.ProfesseurHoraire.Name = "ProfesseurHoraire";
            this.ProfesseurHoraire.Size = new System.Drawing.Size(352, 275);
            this.ProfesseurHoraire.TabIndex = 8;
            this.ProfesseurHoraire.TabStop = false;
            this.ProfesseurHoraire.Text = "Horaires";
            // 
            // ProfesseurRecherche
            // 
            this.ProfesseurRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesseurRecherche.Location = new System.Drawing.Point(7, 6);
            this.ProfesseurRecherche.Name = "ProfesseurRecherche";
            this.ProfesseurRecherche.Size = new System.Drawing.Size(712, 260);
            this.ProfesseurRecherche.TabIndex = 7;
            this.ProfesseurRecherche.TabStop = false;
            this.ProfesseurRecherche.Text = "Recherche";
            // 
            // ProfesseurCoordonnees
            // 
            this.ProfesseurCoordonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesseurCoordonnees.Location = new System.Drawing.Point(8, 272);
            this.ProfesseurCoordonnees.Name = "ProfesseurCoordonnees";
            this.ProfesseurCoordonnees.Size = new System.Drawing.Size(351, 275);
            this.ProfesseurCoordonnees.TabIndex = 6;
            this.ProfesseurCoordonnees.TabStop = false;
            this.ProfesseurCoordonnees.Text = "Informations générales";
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
            this.tabEtudiant.Controls.Add(this.EtudiantHoraire);
            this.tabEtudiant.Controls.Add(this.EtudiantRecherche);
            this.tabEtudiant.Controls.Add(this.EtudiantCoordonnees);
            this.tabEtudiant.Location = new System.Drawing.Point(4, 22);
            this.tabEtudiant.Name = "tabEtudiant";
            this.tabEtudiant.Padding = new System.Windows.Forms.Padding(3);
            this.tabEtudiant.Size = new System.Drawing.Size(727, 553);
            this.tabEtudiant.TabIndex = 2;
            this.tabEtudiant.Text = "tabEtudiant";
            this.tabEtudiant.UseVisualStyleBackColor = true;
            // 
            // EtudiantHoraire
            // 
            this.EtudiantHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudiantHoraire.Location = new System.Drawing.Point(369, 272);
            this.EtudiantHoraire.Name = "EtudiantHoraire";
            this.EtudiantHoraire.Size = new System.Drawing.Size(352, 275);
            this.EtudiantHoraire.TabIndex = 5;
            this.EtudiantHoraire.TabStop = false;
            this.EtudiantHoraire.Text = "Horaires";
            // 
            // EtudiantRecherche
            // 
            this.EtudiantRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudiantRecherche.Location = new System.Drawing.Point(7, 6);
            this.EtudiantRecherche.Name = "EtudiantRecherche";
            this.EtudiantRecherche.Size = new System.Drawing.Size(712, 260);
            this.EtudiantRecherche.TabIndex = 4;
            this.EtudiantRecherche.TabStop = false;
            this.EtudiantRecherche.Text = "Recherche";
            // 
            // EtudiantCoordonnees
            // 
            this.EtudiantCoordonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudiantCoordonnees.Location = new System.Drawing.Point(8, 272);
            this.EtudiantCoordonnees.Name = "EtudiantCoordonnees";
            this.EtudiantCoordonnees.Size = new System.Drawing.Size(351, 275);
            this.EtudiantCoordonnees.TabIndex = 3;
            this.EtudiantCoordonnees.TabStop = false;
            this.EtudiantCoordonnees.Text = "Informations générales";
            // 
            // tabAdministration
            // 
            this.tabAdministration.Controls.Add(this.AdminRecherche);
            this.tabAdministration.Controls.Add(this.AdminInfo);
            this.tabAdministration.Location = new System.Drawing.Point(4, 22);
            this.tabAdministration.Name = "tabAdministration";
            this.tabAdministration.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdministration.Size = new System.Drawing.Size(727, 553);
            this.tabAdministration.TabIndex = 3;
            this.tabAdministration.Text = "tabAdministration";
            this.tabAdministration.UseVisualStyleBackColor = true;
            // 
            // AdminRecherche
            // 
            this.AdminRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRecherche.Location = new System.Drawing.Point(7, 6);
            this.AdminRecherche.Name = "AdminRecherche";
            this.AdminRecherche.Size = new System.Drawing.Size(713, 260);
            this.AdminRecherche.TabIndex = 4;
            this.AdminRecherche.TabStop = false;
            this.AdminRecherche.Text = "Recherche";
            // 
            // AdminInfo
            // 
            this.AdminInfo.Controls.Add(this.controleAdmin1);
            this.AdminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminInfo.Location = new System.Drawing.Point(8, 272);
            this.AdminInfo.Name = "AdminInfo";
            this.AdminInfo.Size = new System.Drawing.Size(712, 275);
            this.AdminInfo.TabIndex = 3;
            this.AdminInfo.TabStop = false;
            this.AdminInfo.Text = "Informations générales";
            // 
            // controleAdmin1
            // 
            this.controleAdmin1.Location = new System.Drawing.Point(7, 26);
            this.controleAdmin1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controleAdmin1.Name = "controleAdmin1";
            this.controleAdmin1.Size = new System.Drawing.Size(698, 241);
            this.controleAdmin1.TabIndex = 0;
            this.controleAdmin1.ClickBtnSaveOrUpdate += new System.EventHandler<ControlCoordonées.EventAdmin>(btnAdminSaveOrUpdate_Click);
            this.controleAdmin1.ClickBtnDelete += new System.EventHandler<ControlCoordonées.EventAdmin>(btnAdminDelete_Click);
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
            this.tabEtudiant.ResumeLayout(false);
            this.tabAdministration.ResumeLayout(false);
            this.AdminInfo.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox ProfesseurHoraire;
        private System.Windows.Forms.GroupBox ProfesseurRecherche;
        private System.Windows.Forms.GroupBox ProfesseurCoordonnees;
        private System.Windows.Forms.GroupBox EtudiantHoraire;
        private System.Windows.Forms.GroupBox EtudiantRecherche;
        private System.Windows.Forms.GroupBox EtudiantCoordonnees;
        private System.Windows.Forms.GroupBox AdminRecherche;
        private System.Windows.Forms.GroupBox AdminInfo;
        private ControlCoordonées.ControleAdmin controleAdmin1;
    }
}