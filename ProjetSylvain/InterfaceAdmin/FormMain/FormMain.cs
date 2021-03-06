﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Backend;
using Backend.Interfaces.Implementations;

namespace InterfaceAdmin
{
	public partial class FormMain : Form
	{
		// varialble
        const string RECHERCHE_PAR_ID = "ID";
        const string RECHERCHE_PAR_IDENTIFIANT = "Identifiant";
        const string RECHERCHE_PAR_NOM = "Nom";
        const string RECHERCHE_PAR_PRENOM = "Prenom";

        const string onSaveOrUpdateMessage = "Êtes-vous certain de vouloir sauvegarder?";
        const string onDeleteMessage = "Êtes-vous certain de vouloir supprimer cet enregistrement?";

		// Constucteur
		public FormMain()
		{
			InitializeComponent();
            FillComboBoxes();
		}
		// Button pour changer de tab
		private void btnProfesseur_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabProfesseur");
		}
		// Button pour changer de tab
		private void btnEtudiant_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabEtudiant");
		}
		// Button pour changer de tab
		private void btnCours_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabCours");
		}
		// Button pour changer de tab
		private void btnAdministration_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabAdministration");
		}
		// Button pour quitter
		private void btnQuitter_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		// Message d'alert
        void WarningMessage(string message)
        {
            MessageBox.Show(message);
        }
		// message par default pour sauvegarder
        DialogResult WarningSaving()
        {
            return MessageBox.Show(onSaveOrUpdateMessage, "Sauvegarder?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
		// message par default pour delete
        DialogResult WarningDeleting()
        {
            return MessageBox.Show(onDeleteMessage, "Supprimer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
		// toString générique
        string FormatACertainObjectIntoAPrettyStringForDisplay(Object o)
        {
            string LoginFormat = "{0} {1}";
            string CoordonneesFormat = "{0} {1} {2}";
            if (o.GetType().IsSubclassOf(typeof(Login)))
            {
                Login l = (Login) o;
                return String.Format(LoginFormat, l.Id, l.Code);
            }
            else if (o.GetType().IsSubclassOf(typeof(Etudiant)))
            {
                Etudiant e = (Etudiant) o;
                return String.Format(CoordonneesFormat, e.Coordonnees.Id, e.Coordonnees.Prenom, e.Coordonnees.Nom);
            }
            else if (o.GetType().IsSubclassOf(typeof(Professeur)))
            {
                Professeur p = (Professeur) o;
                return String.Format(CoordonneesFormat, p.Coordonnees.Id, p.Coordonnees.Prenom, p.Coordonnees.Nom);
            }

            return "Objet inconnu";
        }
		// Contenu des combo box's
        void FillComboBoxes()
        {
            this.cbAdminRecherche.Items.Add(RECHERCHE_PAR_ID);
			this.cbAdminRecherche.Items.Add(RECHERCHE_PAR_IDENTIFIANT);

            this.cbEtudiantRecherche.Items.Add(RECHERCHE_PAR_ID);
            this.cbEtudiantRecherche.Items.Add(RECHERCHE_PAR_NOM);
            this.cbEtudiantRecherche.Items.Add(RECHERCHE_PAR_PRENOM);

            this.cbProfesseurRecherche.Items.Add(RECHERCHE_PAR_ID);
            this.cbProfesseurRecherche.Items.Add(RECHERCHE_PAR_NOM);
            this.cbProfesseurRecherche.Items.Add(RECHERCHE_PAR_PRENOM);
        }


	}

    //HACK: Tabless TabControl http://stackoverflow.com/a/6954785
	public class TablessControl : TabControl
	{
		protected override void WndProc(ref Message m)
		{
			// Hide tabs by trapping the TCM_ADJUSTRECT message
			if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
			else base.WndProc(ref m);
		}
	}
}
