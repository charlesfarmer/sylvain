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
    public partial class ControleLogin : Controle
    {
        #region constructor
        public ControleLogin()
        {
            InitializeComponent();
        }
        #endregion
        #region events
        public event EventHandler<EventConnexion> ClickBtnConnexion;
        #endregion
        #region event handlers
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string identifiant = this.txtIdentifiant.Text;
            string password = this.txtPassword.Text;
            if (ClickBtnConnexion != null)
            {
                ClickBtnConnexion(this, new EventConnexion(identifiant, password));
            }
        }
        #endregion
        #region functions
        public void FocusIdentifiant()
        {
            this.txtIdentifiant.Focus();
        }
        public void FocusPassword()
        {
            this.txtPassword.Focus();
        }
        #endregion
    }

    public class EventConnexion : EventArgs
    {//bobe
        public string Identifiant { get; private set; }
        public string Password { get; private set; }
        public EventConnexion(string identifiant, string password)
        {
            this.Identifiant = identifiant;
            this.Password = password;
        }
    }
}
