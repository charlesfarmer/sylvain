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
using Backend.Interfaces.Implementations;

namespace InterfaceAdmin
{
    public partial class FormLogin : Form
    {
		// Variable de class
        const string warningMessageIdentifiant = "Vous devez entrer un identifiant!";
        const string warningMessagePassword = "Vous devez entrer un mot de passe!";
        const string warningMessageLoginFailed = "L'identifiant ou le mot de passe est invalide.";

        Random Random = new Random();
		// Constructeur
        public FormLogin()
        {
            InitializeComponent();
            #region event bindings
            this.controleLogin1.ClickBtnConnexion += new EventHandler<EventConnexion>(validateCredentials);
            #endregion
        }
        #region event handlers
		// Code pour validate le ID & PW des utilisateurs
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

            if (Facade.ServiceLogin.FindByCodeAndPass(u, p, false) != null && Facade.ServiceLogin.FindByCodeAndPass(u, p, false).IsAdmin)
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
		// call un message dépendemment de l'erreur
        void WarningMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
