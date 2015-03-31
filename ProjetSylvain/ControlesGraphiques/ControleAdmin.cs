using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlesGraphiques;

namespace ControlCoordonées
{
	public partial class ControleAdmin : Controle
    {
        #region constructor
        public ControleAdmin()
		{
			InitializeComponent();
		}
        #endregion
        #region events
        public event EventHandler<EventAdmin> ClickBtnSaveOrUpdate;
        public event EventHandler<EventAdmin> ClickBtnDelete;
        #endregion
        #region event handlers
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            string identifiant = this.txtIdentifiant.Text;
            string password = this.txtPassword.Text;
            if (ClickBtnSaveOrUpdate != null)
            {
                ClickBtnSaveOrUpdate(this, new EventAdmin(id, identifiant, password));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            string identifiant = this.txtIdentifiant.Text;
            string password = this.txtPassword.Text;
            if (ClickBtnSaveOrUpdate != null)
            {
                ClickBtnDelete(this, new EventAdmin(id, identifiant, password));
            }
        }
        #endregion
    }

    public class EventAdmin : EventArgs
    {//bobe
        public string Id { get; private set; }
        public string Identifiant { get; private set; }
        public string Password { get; private set; }
        public EventAdmin(string id, string identifiant, string password)
        {
            this.Id = id;
            this.Identifiant = identifiant;
            this.Password = password;
        }
    }
}
