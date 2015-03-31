using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Backend;

namespace InterfaceAdmin
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
            this.cbAdminRecherche.Items.Add("ALLO");
            this.cbAdminRecherche.Items.Add("BONJOUR");
		}

		private void btnProfesseur_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabProfesseur");
		}

		private void btnEtudiant_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabEtudiant");
		}

		private void btnCours_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabCours");
		}

		private void btnAdministration_Click(object sender, EventArgs e)
		{
			this.tablessControl1.SelectTab("tabAdministration");
		}

		private void btnQuitter_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void btnAdminRechercher_Click(object sender, EventArgs e)
        {
            if (this.cbAdminRecherche.SelectedIndex < 0)
            {
                WarningMessage("Il faut un terme de recherche");
                return;
            }
            string typeDeRecherche = this.cbAdminRecherche.SelectedIndex.ToString();
            string texteATrouver = this.txtAdminRecherche.Text.ToLowerInvariant();
            MessageBox.Show(String.Format("{0} {1}", typeDeRecherche, texteATrouver));

            // call à la BD pour trouver des elements

            Login l1 = new Login()
            {
                Id = 1,
                Code = "meow"
            };
            Login l2 = new Login()
            {
                Id = 2,
                Code = "chat"
            };
            List<Login> logins = new List<Login>();
            logins.Add(l1);
            logins.Add(l2);
            
            //

            if (!logins.Any())
            {
                WarningMessage("Aucun résultat");
                return;
            }
            else
            {
                WarningMessage(logins.Count+" résultats trouvés");
            }

            foreach (Login l in logins)
            {
                FormatACertainObjectIntoAPrettyStringForDisplay(l);
            }
        }

        private void btnAdminNouveau_Click(object sender, EventArgs e)
        {
            this.cbAdminRecherche.SelectedIndex = -1;
            this.txtAdminRecherche.Clear();
        }

        void WarningMessage(string message)
        {
            MessageBox.Show(message);
        }

        string FormatACertainObjectIntoAPrettyStringForDisplay(Object o)
        {
            string LoginFormat = "{0} {1}";

            if (typeof(Login) == o.GetType())
            {
                Login l = (Login) o;
                return String.Format(LoginFormat, l.Id, l.Code);
            }

            return "FormatDéfaut";
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
