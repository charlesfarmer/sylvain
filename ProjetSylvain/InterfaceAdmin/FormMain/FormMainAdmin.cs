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


namespace InterfaceAdmin
{
    public partial class FormMain : Form
    {
        private void btnAdminRechercher_Click(object sender, EventArgs e)
        {
            if (this.cbAdminRecherche.SelectedIndex < 0)
            {
                WarningMessage("Il faut un type de recherche");
                this.cbAdminRecherche.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtAdminRecherche.Text))
            {
                WarningMessage("Il faut un terme à chercher");
                this.txtAdminRecherche.Focus();
                return;
            }

            string typeDeRecherche = this.cbAdminRecherche.SelectedItem.ToString();
            string texteATrouver = this.txtAdminRecherche.Text.ToLowerInvariant();

            // call à la BD pour trouver des elements

            List<Login> logins = new List<Login>();

            if (!logins.Any())
            {
                WarningMessage("Aucun résultat");
                return;
            }
            else
            {
                WarningMessage(logins.Count + " résultats trouvés");
            }

            foreach (Login l in logins)
            {
                this.lbAdminResultats.Items.Add(FormatACertainObjectIntoAPrettyStringForDisplay(l));
            }
        }

        private void btnAdminNouveau_Click(object sender, EventArgs e)
        {
            this.cbAdminRecherche.SelectedIndex = -1;
            this.txtAdminRecherche.Clear();
            this.lbAdminResultats.Items.Clear();
        }

        private void lbAdminResultats_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbAdminResultats.SelectedItem.ToString();
            
            // GET un admin de la bd à partir d'un id
            Login login = new Login();
            this.controleAdmin1.Data(login);
        }

        private void btnAdminSaveOrUpdate_Click(object sender, EventAdmin e)
        {
            Login login = new Login()
            {
                IsAdmin = true,
                Id = string.IsNullOrWhiteSpace(e.Id) ? -1 : int.Parse(e.Id),
                Code = e.Identifiant,
                Mot_de_Passe = e.Password
            };

            if (string.IsNullOrEmpty(login.Code) || string.IsNullOrEmpty(login.Mot_de_Passe))
            {
                WarningMessage("Il faut un code d'identifiant et un mot de passe");
                return;
            }

            // TODO: vérifier que le code d'identifiant n'existe pas déjà à l'ajout

            if (WarningSaving() == DialogResult.OK)
            {
                if (login.Id < 0)
                {
                    // call à la BD pour un add
                }
                else
                {
                    // call à la BD pour un update
                }
            }
        }

        private void btnAdminDelete_Click(object sender, EventAdmin e)
        {
            if (WarningDeleting() == DialogResult.OK)
            {
                // call à la BD pour un delete
            }
        }
    }
}
