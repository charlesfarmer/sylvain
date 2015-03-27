using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlCoordonées
{
    public partial class ControleLogin : UserControl
    {
        #region constructor
        public ControleLogin()
        {
            InitializeComponent();
        }
        #endregion
        #region properties
        public string TxtIdentifiant
        {
            get;
            set;
        }
        public string TxtPassword
        {
            get;
            set;
        }
        #endregion
        #region events
        public event EventHandler<EventConnexion> ClickBtnConnexion;
        #endregion
        #region event handlers
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string identifiant = this.TxtIdentifiant;
            string password = this.TxtPassword;
            if (ClickBtnConnexion != null)
            {
                ClickBtnConnexion(this, new EventConnexion(identifiant, password));
            }
        }
        #endregion
    }

    public class EventConnexion : EventArgs
    {
        public string Identifiant { get; private set; }
        public string Password { get; private set; }
        public EventConnexion(string identifiant, string password)
        {
            this.Identifiant = identifiant;
            this.Password = password;
        }
    }
}
