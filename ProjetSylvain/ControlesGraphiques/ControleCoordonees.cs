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
    public partial class ControleCoordonees: Controle
    {
        #region constructor
        public ControleCoordonees()
        {
            InitializeComponent();
        }
        #endregion
        #region function
        public void SetCoordonnees(string nom, string prenom, string adresse, string telephone)
        {
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtAdresse.Text = adresse;
            txtTelephone.Text = telephone;
        }
        #endregion
    }
}
