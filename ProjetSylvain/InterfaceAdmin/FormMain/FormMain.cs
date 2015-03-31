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
		public FormMain()
		{
			InitializeComponent();
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
