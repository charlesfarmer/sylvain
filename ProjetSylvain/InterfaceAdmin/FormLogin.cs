using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlCoordonées;

namespace InterfaceAdmin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            #region event bindings
            this.controleLogin1.ClickBtnConnexion += new EventHandler<EventConnexion>(validateCredentials);
            #endregion
        }
        #region event handlers
        public void validateCredentials(object sender, EventConnexion e)
        {
            // valide l'information avec la BD
            //
            // si valide
            //   lancer la fenêtre principale
            // sinon
            //   lancer un message d'erreur et effacer les champs
            string u = e.Identifiant;
            string p = e.Password;
        }
        #endregion
    }
}
