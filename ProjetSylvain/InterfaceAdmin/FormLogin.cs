using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Backend;
using Backend.Services.Interfaces;
using Backend.Services.Implementations;
using ControlCoordonées;

namespace InterfaceAdmin
{
    public partial class FormLogin : Form
    {
        const string warningMessageIdentifiant = "Ruh roh\n\nYou missing rusername!";
        const string warningMessagePassword = "Ruh roh\n\nYou missing passrurd!";
        const string warningMessageLoginFailed = "SCOOBY DOOO";

        Random Random = new Random();

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
            string u = e.Identifiant;
            string p = e.Password;

            if (string.IsNullOrEmpty(u))
            {
                WarningMessage(warningMessageIdentifiant);
                this.controleLogin1.FocusIdentifiant();
                return;
            }
            else if (string.IsNullOrEmpty(p))
            {
                WarningMessage(warningMessagePassword);
                this.controleLogin1.FocusPassword();
                return;
            }

            Login login = new Login
            {
                Code = u,
                Mot_de_Passe = p
            };

            if (Random.Next(0, 2) % 2 == 0) // TODO: 👽 ayy 👽👽 lmao 👽
            {
                this.DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                WarningMessage(warningMessageLoginFailed);
                this.controleLogin1.ClearFields();
            }
        }
        #endregion

        void WarningMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
