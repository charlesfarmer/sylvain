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
		// Methode pour rechercher les administrateurs lorsqu'on click sure le button rechercher
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

            List<Login> logins = new List<Login>();

			logins = Facade.ServiceLogin.FindByCritere(typeDeRecherche, texteATrouver);

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
		// Clear les champs pour entrer de nouvelle info
        private void btnAdminNouveau_Click(object sender, EventArgs e)
        {
            this.cbAdminRecherche.SelectedIndex = -1;
            this.txtAdminRecherche.Clear();
            this.lbAdminResultats.Items.Clear();
        }
		// rentre les info selectionner dans controleAdmin en appellent : setInfoAdmin();
        private void lbAdminResultats_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbAdminResultats.SelectedItem.ToString();
            
            Login login = new Login();
            this.controleAdmin1.Data(login);
			Facade.ServiceLogin.Get(login.Id);
			setInfoAdmin(login);
        }
		// ... set les info de l'admin 
		private void setInfoAdmin(Login login)
		{
			this.controleAdmin1.ID = login.Id.ToString();
			this.controleAdmin1.Identification = login.Code;
			this.controleAdmin1.Password = login.Mot_de_Passe;
		}
		// sauvegarde les info rentrer apres une verification
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

			if (Facade.ServiceLogin.Get(login.Id) != null)
			{
				if (WarningSaving() == DialogResult.OK)
				{
					if (login.Id < 0)
					{
						Facade.ServiceLogin.Add(login);
					}
					else
					{
						Facade.ServiceLogin.Update(login);
					}
				}
			}
        }
		// delete l'admin
        private void btnAdminDelete_Click(object sender, EventAdmin e)
        {
            if (WarningDeleting() == DialogResult.OK)
            {
                // call à la BD pour un delete
            }
        }
    }
}
