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
            this.btnProfesseurRechercher = new System.Windows.Forms.Button();
            this.btnProfesseurNouveau = new System.Windows.Forms.Button();
            this.lblProfesseurTypeRecherche = new System.Windows.Forms.Label();
            this.txtProfesseurRecherche = new System.Windows.Forms.TextBox();
            this.cbProfesseurRecherche = new System.Windows.Forms.ComboBox();
            this.ProfesseurResultats = new System.Windows.Forms.GroupBox();
            this.lbProfesseurResultats = new System.Windows.Forms.ListBox();
            this.ProfesseurCoordonnees = new System.Windows.Forms.GroupBox();
            this.tabCours = new System.Windows.Forms.TabPage();
            this.tabEtudiant = new System.Windows.Forms.TabPage();
            this.EtudiantRecherche = new System.Windows.Forms.GroupBox();
            this.btnEtudiantRechercher = new System.Windows.Forms.Button();
            this.btnEtudiantNouveau = new System.Windows.Forms.Button();
            this.lblEtudiantTypeRecherche = new System.Windows.Forms.Label();
            this.txtEtudiantRecherche = new System.Windows.Forms.TextBox();
            this.cbEtudiantRecherche = new System.Windows.Forms.ComboBox();
            this.EtudiantResultats = new System.Windows.Forms.GroupBox();
            this.lbEtudiantResultats = new System.Windows.Forms.ListBox();
            this.EtudiantCoordonnees = new System.Windows.Forms.GroupBox();
            this.tabAdministration = new System.Windows.Forms.TabPage();
            this.AdminRecherche = new System.Windows.Forms.GroupBox();
            this.btnAdminRechercher = new System.Windows.Forms.Button();
            this.btnAdminNouveau = new System.Windows.Forms.Button();
            this.lblAdminTypeRecherche = new System.Windows.Forms.Label();
            this.txtAdminRecherche = new System.Windows.Forms.TextBox();
            this.cbAdminRecherche = new System.Windows.Forms.ComboBox();
            this.AdminResultats = new System.Windows.Forms.GroupBox();
            this.lbAdminResultats = new System.Windows.Forms.ListBox();
            this.AdminInfo = new System.Windows.Forms.GroupBox();
            this.controleAdmin1 = new ControlCoordonées.ControleAdmin();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tablessControl1.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.ProfesseurRecherche.SuspendLayout();
            this.ProfesseurResultats.SuspendLayout();
            this.ProfesseurCoordonnees.SuspendLayout();
            this.tabEtudiant.SuspendLayout();
            this.EtudiantRecherche.SuspendLayout();
            this.EtudiantResultats.SuspendLayout();
            this.tabAdministration.SuspendLayout();
            this.AdminRecherche.SuspendLayout();
            this.AdminResultats.SuspendLayout();
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
            this.ProfesseurHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesseurHoraire.Location = new System.Drawing.Point(468, 11);
            this.ProfesseurHoraire.Name = "ProfesseurHoraire";
            this.ProfesseurHoraire.Size = new System.Drawing.Size(237, 258);
            this.ProfesseurHoraire.TabIndex = 8;
            this.ProfesseurHoraire.TabStop = false;
            this.ProfesseurHoraire.Text = "Horaires";
            // 
            // ProfesseurRecherche
            // 
            this.ProfesseurRecherche.Controls.Add(this.btnProfesseurRechercher);
            this.ProfesseurRecherche.Controls.Add(this.btnProfesseurNouveau);
            this.ProfesseurRecherche.Controls.Add(this.lblProfesseurTypeRecherche);
            this.ProfesseurRecherche.Controls.Add(this.txtProfesseurRecherche);
            this.ProfesseurRecherche.Controls.Add(this.cbProfesseurRecherche);
            this.ProfesseurRecherche.Controls.Add(this.ProfesseurResultats);
            this.ProfesseurRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesseurRecherche.Location = new System.Drawing.Point(7, 6);
            this.ProfesseurRecherche.Name = "ProfesseurRecherche";
            this.ProfesseurRecherche.Size = new System.Drawing.Size(712, 260);
            this.ProfesseurRecherche.TabIndex = 7;
            this.ProfesseurRecherche.TabStop = false;
            this.ProfesseurRecherche.Text = "Recherche Professeur";
            // 
            // btnProfesseurRechercher
            // 
            this.btnProfesseurRechercher.Location = new System.Drawing.Point(9, 172);
            this.btnProfesseurRechercher.Name = "btnProfesseurRechercher";
            this.btnProfesseurRechercher.Size = new System.Drawing.Size(82, 31);
            this.btnProfesseurRechercher.TabIndex = 12;
            this.btnProfesseurRechercher.Text = "Chercher";
            this.btnProfesseurRechercher.UseVisualStyleBackColor = true;
            this.btnProfesseurRechercher.Click += new System.EventHandler(this.btnProfesseurRechercher_Click);
            // 
            // btnProfesseurNouveau
            // 
            this.btnProfesseurNouveau.Location = new System.Drawing.Point(106, 172);
            this.btnProfesseurNouveau.Name = "btnProfesseurNouveau";
            this.btnProfesseurNouveau.Size = new System.Drawing.Size(82, 31);
            this.btnProfesseurNouveau.TabIndex = 11;
            this.btnProfesseurNouveau.Text = "Nouveau";
            this.btnProfesseurNouveau.UseVisualStyleBackColor = true;
            this.btnProfesseurNouveau.Click += new System.EventHandler(this.btnProfesseurNouveau_Click);
            // 
            // lblProfesseurTypeRecherche
            // 
            this.lblProfesseurTypeRecherche.AutoSize = true;
            this.lblProfesseurTypeRecherche.Location = new System.Drawing.Point(8, 54);
            this.lblProfesseurTypeRecherche.Name = "lblProfesseurTypeRecherche";
            this.lblProfesseurTypeRecherche.Size = new System.Drawing.Size(23, 13);
            this.lblProfesseurTypeRecherche.TabIndex = 10;
            this.lblProfesseurTypeRecherche.Text = "Par";
            // 
            // txtProfesseurRecherche
            // 
            this.txtProfesseurRecherche.Location = new System.Drawing.Point(8, 110);
            this.txtProfesseurRecherche.Name = "txtProfesseurRecherche";
            this.txtProfesseurRecherche.Size = new System.Drawing.Size(201, 20);
            this.txtProfesseurRecherche.TabIndex = 9;
            // 
            // cbProfesseurRecherche
            // 
            this.cbProfesseurRecherche.FormattingEnabled = true;
            this.cbProfesseurRecherche.Location = new System.Drawing.Point(8, 74);
            this.cbProfesseurRecherche.Name = "cbProfesseurRecherche";
            this.cbProfesseurRecherche.Size = new System.Drawing.Size(121, 21);
            this.cbProfesseurRecherche.TabIndex = 8;
            // 
            // ProfesseurResultats
            // 
            this.ProfesseurResultats.Controls.Add(this.lbProfesseurResultats);
            this.ProfesseurResultats.Location = new System.Drawing.Point(261, 13);
            this.ProfesseurResultats.Name = "ProfesseurResultats";
            this.ProfesseurResultats.Size = new System.Drawing.Size(443, 235);
            this.ProfesseurResultats.TabIndex = 13;
            this.ProfesseurResultats.TabStop = false;
            this.ProfesseurResultats.Text = "Résultats";
            // 
            // lbProfesseurResultats
            // 
            this.lbProfesseurResultats.FormattingEnabled = true;
            this.lbProfesseurResultats.Location = new System.Drawing.Point(7, 17);
            this.lbProfesseurResultats.Name = "lbProfesseurResultats";
            this.lbProfesseurResultats.Size = new System.Drawing.Size(430, 212);
            this.lbProfesseurResultats.TabIndex = 0;
            // 
            // ProfesseurCoordonnees
            // 
            this.ProfesseurCoordonnees.Controls.Add(this.ProfesseurHoraire);
            this.ProfesseurCoordonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesseurCoordonnees.Location = new System.Drawing.Point(8, 272);
            this.ProfesseurCoordonnees.Name = "ProfesseurCoordonnees";
            this.ProfesseurCoordonnees.Size = new System.Drawing.Size(711, 275);
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
            // EtudiantRecherche
            // 
            this.EtudiantRecherche.Controls.Add(this.btnEtudiantRechercher);
            this.EtudiantRecherche.Controls.Add(this.btnEtudiantNouveau);
            this.EtudiantRecherche.Controls.Add(this.lblEtudiantTypeRecherche);
            this.EtudiantRecherche.Controls.Add(this.txtEtudiantRecherche);
            this.EtudiantRecherche.Controls.Add(this.cbEtudiantRecherche);
            this.EtudiantRecherche.Controls.Add(this.EtudiantResultats);
            this.EtudiantRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudiantRecherche.Location = new System.Drawing.Point(7, 6);
            this.EtudiantRecherche.Name = "EtudiantRecherche";
            this.EtudiantRecherche.Size = new System.Drawing.Size(712, 260);
            this.EtudiantRecherche.TabIndex = 4;
            this.EtudiantRecherche.TabStop = false;
            this.EtudiantRecherche.Text = "Recherche Étudiant";
            // 
            // btnEtudiantRechercher
            // 
            this.btnEtudiantRechercher.Location = new System.Drawing.Point(9, 172);
            this.btnEtudiantRechercher.Name = "btnEtudiantRechercher";
            this.btnEtudiantRechercher.Size = new System.Drawing.Size(82, 31);
            this.btnEtudiantRechercher.TabIndex = 12;
            this.btnEtudiantRechercher.Text = "Chercher";
            this.btnEtudiantRechercher.UseVisualStyleBackColor = true;
            this.btnEtudiantRechercher.Click += new System.EventHandler(this.btnEtudiantRechercher_Click);
            // 
            // btnEtudiantNouveau
            // 
            this.btnEtudiantNouveau.Location = new System.Drawing.Point(106, 172);
            this.btnEtudiantNouveau.Name = "btnEtudiantNouveau";
            this.btnEtudiantNouveau.Size = new System.Drawing.Size(82, 31);
            this.btnEtudiantNouveau.TabIndex = 11;
            this.btnEtudiantNouveau.Text = "Nouveau";
            this.btnEtudiantNouveau.UseVisualStyleBackColor = true;
            this.btnEtudiantNouveau.Click += new System.EventHandler(this.btnEtudiantNouveau_Click);
            // 
            // lblEtudiantTypeRecherche
            // 
            this.lblEtudiantTypeRecherche.AutoSize = true;
            this.lblEtudiantTypeRecherche.Location = new System.Drawing.Point(8, 54);
            this.lblEtudiantTypeRecherche.Name = "lblEtudiantTypeRecherche";
            this.lblEtudiantTypeRecherche.Size = new System.Drawing.Size(23, 13);
            this.lblEtudiantTypeRecherche.TabIndex = 10;
            this.lblEtudiantTypeRecherche.Text = "Par";
            // 
            // txtEtudiantRecherche
            // 
            this.txtEtudiantRecherche.Location = new System.Drawing.Point(8, 110);
            this.txtEtudiantRecherche.Name = "txtEtudiantRecherche";
            this.txtEtudiantRecherche.Size = new System.Drawing.Size(201, 20);
            this.txtEtudiantRecherche.TabIndex = 9;
            // 
            // cbEtudiantRecherche
            // 
            this.cbEtudiantRecherche.FormattingEnabled = true;
            this.cbEtudiantRecherche.Location = new System.Drawing.Point(8, 74);
            this.cbEtudiantRecherche.Name = "cbEtudiantRecherche";
            this.cbEtudiantRecherche.Size = new System.Drawing.Size(121, 21);
            this.cbEtudiantRecherche.TabIndex = 8;
            // 
            // EtudiantResultats
            // 
            this.EtudiantResultats.Controls.Add(this.lbEtudiantResultats);
            this.EtudiantResultats.Location = new System.Drawing.Point(261, 13);
            this.EtudiantResultats.Name = "EtudiantResultats";
            this.EtudiantResultats.Size = new System.Drawing.Size(443, 235);
            this.EtudiantResultats.TabIndex = 13;
            this.EtudiantResultats.TabStop = false;
            this.EtudiantResultats.Text = "Résultats";
            // 
            // lbEtudiantResultats
            // 
            this.lbEtudiantResultats.FormattingEnabled = true;
            this.lbEtudiantResultats.Location = new System.Drawing.Point(7, 17);
            this.lbEtudiantResultats.Name = "lbEtudiantResultats";
            this.lbEtudiantResultats.Size = new System.Drawing.Size(430, 212);
            this.lbEtudiantResultats.TabIndex = 0;
            // 
            // EtudiantCoordonnees
            // 
            this.EtudiantCoordonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtudiantCoordonnees.Location = new System.Drawing.Point(8, 272);
            this.EtudiantCoordonnees.Name = "EtudiantCoordonnees";
            this.EtudiantCoordonnees.Size = new System.Drawing.Size(711, 275);
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
            this.AdminRecherche.Controls.Add(this.btnAdminRechercher);
            this.AdminRecherche.Controls.Add(this.btnAdminNouveau);
            this.AdminRecherche.Controls.Add(this.lblAdminTypeRecherche);
            this.AdminRecherche.Controls.Add(this.txtAdminRecherche);
            this.AdminRecherche.Controls.Add(this.cbAdminRecherche);
            this.AdminRecherche.Controls.Add(this.AdminResultats);
            this.AdminRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRecherche.Location = new System.Drawing.Point(7, 6);
            this.AdminRecherche.Name = "AdminRecherche";
            this.AdminRecherche.Size = new System.Drawing.Size(713, 260);
            this.AdminRecherche.TabIndex = 4;
            this.AdminRecherche.TabStop = false;
            this.AdminRecherche.Text = "Recherche Administrateur";
            // 
            // btnAdminRechercher
            // 
            this.btnAdminRechercher.Location = new System.Drawing.Point(9, 172);
            this.btnAdminRechercher.Name = "btnAdminRechercher";
            this.btnAdminRechercher.Size = new System.Drawing.Size(82, 31);
            this.btnAdminRechercher.TabIndex = 12;
            this.btnAdminRechercher.Text = "Chercher";
            this.btnAdminRechercher.UseVisualStyleBackColor = true;
            this.btnAdminRechercher.Click += new System.EventHandler(this.btnAdminRechercher_Click);
            // 
            // btnAdminNouveau
            // 
            this.btnAdminNouveau.Location = new System.Drawing.Point(106, 172);
            this.btnAdminNouveau.Name = "btnAdminNouveau";
            this.btnAdminNouveau.Size = new System.Drawing.Size(82, 31);
            this.btnAdminNouveau.TabIndex = 11;
            this.btnAdminNouveau.Text = "Nouveau";
            this.btnAdminNouveau.UseVisualStyleBackColor = true;
            this.btnAdminNouveau.Click += new System.EventHandler(this.btnAdminNouveau_Click);
            // 
            // lblAdminTypeRecherche
            // 
            this.lblAdminTypeRecherche.AutoSize = true;
            this.lblAdminTypeRecherche.Location = new System.Drawing.Point(8, 54);
            this.lblAdminTypeRecherche.Name = "lblAdminTypeRecherche";
            this.lblAdminTypeRecherche.Size = new System.Drawing.Size(23, 13);
            this.lblAdminTypeRecherche.TabIndex = 10;
            this.lblAdminTypeRecherche.Text = "Par";
            // 
            // txtAdminRecherche
            // 
            this.txtAdminRecherche.Location = new System.Drawing.Point(8, 110);
            this.txtAdminRecherche.Name = "txtAdminRecherche";
            this.txtAdminRecherche.Size = new System.Drawing.Size(201, 20);
            this.txtAdminRecherche.TabIndex = 9;
            // 
            // cbAdminRecherche
            // 
            this.cbAdminRecherche.FormattingEnabled = true;
            this.cbAdminRecherche.Location = new System.Drawing.Point(8, 74);
            this.cbAdminRecherche.Name = "cbAdminRecherche";
            this.cbAdminRecherche.Size = new System.Drawing.Size(121, 21);
            this.cbAdminRecherche.TabIndex = 8;
            // 
            // AdminResultats
            // 
            this.AdminResultats.Controls.Add(this.lbAdminResultats);
            this.AdminResultats.Location = new System.Drawing.Point(261, 13);
            this.AdminResultats.Name = "AdminResultats";
            this.AdminResultats.Size = new System.Drawing.Size(443, 235);
            this.AdminResultats.TabIndex = 13;
            this.AdminResultats.TabStop = false;
            this.AdminResultats.Text = "Résultats";
            // 
            // lbAdminResultats
            // 
            this.lbAdminResultats.FormattingEnabled = true;
            this.lbAdminResultats.Location = new System.Drawing.Point(7, 17);
            this.lbAdminResultats.Name = "lbAdminResultats";
            this.lbAdminResultats.Size = new System.Drawing.Size(430, 212);
            this.lbAdminResultats.TabIndex = 0;
            this.lbAdminResultats.SelectedValueChanged += new System.EventHandler(this.lbAdminResultats_SelectedValueChanged);
            // 
            // AdminInfo
            // 
            this.AdminInfo.Controls.Add(this.controleAdmin1);
            this.AdminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminInfo.Location = new System.Drawing.Point(8, 272);
            this.AdminInfo.Name = "AdminInfo";
            this.AdminInfo.Size = new System.Drawing.Size(712, 275);
            this.AdminInfo.TabIndex = 3;
            this.AdminInfo.TabStop = false;
            this.AdminInfo.Text = "Informations générales";
            // 
            // controleAdmin1
            // 
            this.controleAdmin1.Location = new System.Drawing.Point(7, 21);
            this.controleAdmin1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controleAdmin1.Name = "controleAdmin1";
            this.controleAdmin1.Size = new System.Drawing.Size(415, 153);
            this.controleAdmin1.TabIndex = 0;
            this.controleAdmin1.ClickBtnSaveOrUpdate += new System.EventHandler<ControlCoordonées.EventAdmin>(this.btnAdminSaveOrUpdate_Click);
            this.controleAdmin1.ClickBtnDelete += new System.EventHandler<ControlCoordonées.EventAdmin>(this.btnAdminDelete_Click);
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
            this.ProfesseurRecherche.ResumeLayout(false);
            this.ProfesseurRecherche.PerformLayout();
            this.ProfesseurResultats.ResumeLayout(false);
            this.ProfesseurCoordonnees.ResumeLayout(false);
            this.tabEtudiant.ResumeLayout(false);
            this.EtudiantRecherche.ResumeLayout(false);
            this.EtudiantRecherche.PerformLayout();
            this.EtudiantResultats.ResumeLayout(false);
            this.tabAdministration.ResumeLayout(false);
            this.AdminRecherche.ResumeLayout(false);
            this.AdminRecherche.PerformLayout();
            this.AdminResultats.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox EtudiantRecherche;
        private System.Windows.Forms.GroupBox EtudiantCoordonnees;
        private System.Windows.Forms.GroupBox AdminRecherche;
        private System.Windows.Forms.GroupBox AdminInfo;
        private ControlCoordonées.ControleAdmin controleAdmin1;
        private System.Windows.Forms.Button btnProfesseurRechercher;
        private System.Windows.Forms.Button btnProfesseurNouveau;
        private System.Windows.Forms.Label lblProfesseurTypeRecherche;
        private System.Windows.Forms.TextBox txtProfesseurRecherche;
        private System.Windows.Forms.ComboBox cbProfesseurRecherche;
        private System.Windows.Forms.GroupBox ProfesseurResultats;
        private System.Windows.Forms.ListBox lbProfesseurResultats;
        private System.Windows.Forms.Button btnEtudiantRechercher;
        private System.Windows.Forms.Button btnEtudiantNouveau;
        private System.Windows.Forms.Label lblEtudiantTypeRecherche;
        private System.Windows.Forms.TextBox txtEtudiantRecherche;
        private System.Windows.Forms.ComboBox cbEtudiantRecherche;
        private System.Windows.Forms.GroupBox EtudiantResultats;
        private System.Windows.Forms.ListBox lbEtudiantResultats;
        private System.Windows.Forms.Button btnAdminRechercher;
        private System.Windows.Forms.Button btnAdminNouveau;
        private System.Windows.Forms.Label lblAdminTypeRecherche;
        private System.Windows.Forms.TextBox txtAdminRecherche;
        private System.Windows.Forms.ComboBox cbAdminRecherche;
        private System.Windows.Forms.GroupBox AdminResultats;
        private System.Windows.Forms.ListBox lbAdminResultats;
    }
}