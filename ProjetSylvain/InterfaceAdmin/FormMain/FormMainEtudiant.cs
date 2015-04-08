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
        private void btnEtudiantRechercher_Click(object sender, EventArgs e)
        {
            if (this.cbEtudiantRecherche.SelectedIndex < 0)
            {
                WarningMessage("Il faut un terme de recherche");
                this.cbEtudiantRecherche.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtEtudiantRecherche.Text))
            {
                WarningMessage("Il faut un terme à chercher");
                this.txtEtudiantRecherche.Focus();
                return;
            }

            string typeDeRecherche = this.cbEtudiantRecherche.SelectedItem.ToString();
            string texteATrouver = this.txtEtudiantRecherche.Text.ToLowerInvariant();

            List<Etudiant> etudiants = new List<Etudiant>();

			etudiants = Facade.ServiceEtudiant.FindByCritere(typeDeRecherche, texteATrouver);

            if (!etudiants.Any())
            {
                WarningMessage("Aucun résultat");
                return;
            }
            else
            {
                WarningMessage(etudiants.Count + " résultats trouvés");
            }

            foreach (Etudiant etudiant in etudiants)
            {
                this.lbEtudiantResultats.Items.Add(FormatACertainObjectIntoAPrettyStringForDisplay(etudiant));
            }
        }

        private void btnEtudiantNouveau_Click(object sender, EventArgs e)
        {
            this.cbEtudiantRecherche.SelectedIndex = -1;
            this.txtEtudiantRecherche.Clear();
            this.lbEtudiantResultats.Items.Clear();
        }
    }
}
