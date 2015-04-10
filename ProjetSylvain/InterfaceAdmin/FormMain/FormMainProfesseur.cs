using ControlCoordonées;
using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Backend.Interfaces.Implementations;


namespace InterfaceAdmin
{
    public partial class FormMain : Form
    {
		// Methode pour rechercher les Prof. lorsqu'on click sure le button rechercher
        private void btnProfesseurRechercher_Click(object sender, EventArgs e)
        {
            if (this.cbProfesseurRecherche.SelectedIndex < 0)
            {
                WarningMessage("Il faut un terme de recherche");
                this.cbProfesseurRecherche.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtProfesseurRecherche.Text))
            {
                WarningMessage("Il faut un terme à chercher");
                this.txtProfesseurRecherche.Focus();
                return;
            }

            string typeDeRecherche = this.cbProfesseurRecherche.SelectedItem.ToString();
            string texteATrouver = this.txtProfesseurRecherche.Text.ToLowerInvariant();

            List<Professeur> professeurs = new List<Professeur>();

			professeurs = Facade.ServiceProfesseur.FindByCritere(typeDeRecherche, texteATrouver);

            if (!professeurs.Any())
            {
                WarningMessage("Aucun résultat");
                return;
            }
            else
            {
                WarningMessage(professeurs.Count + " résultats trouvés");
            }

            foreach (Professeur professeur in professeurs)
            {
                this.lbProfesseurResultats.Items.Add(FormatACertainObjectIntoAPrettyStringForDisplay(professeur));
            }
        }
		// Clear les champs pour entrer de nouvelle info
        private void btnProfesseurNouveau_Click(object sender, EventArgs e)
        {
            this.cbProfesseurRecherche.SelectedIndex = -1;
            this.txtProfesseurRecherche.Clear();
            this.lbProfesseurResultats.Items.Clear();
        }
    }
}
