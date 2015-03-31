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


namespace InterfaceAdmin
{
    public partial class FormMain : Form
    {
        string onSaveOrUpdateMessage = "Êtes-vous certain de vouloir sauvegarder?";
        string onDeleteMessage = "Êtes-vous certain de vouloir supprimer cet enregistrement?";

        private void btnAdminSaveOrUpdate_Click(object sender, EventAdmin e)
        {
            Login login = new Login()
            {
                IsAdmin = true,
                Id = string.IsNullOrWhiteSpace(e.Id) ? -1 : int.Parse(e.Id),
                Code = e.Identifiant,
                Mot_de_Passe = e.Password
            };

            if (MessageBox.Show(onSaveOrUpdateMessage, "Sauvegarder?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (login.Id < 0)
                {
                    // call à la BD pour un add
                }
                else
                {
                    // call à la BD pour un update
                }
            }
        }
        private void btnAdminDelete_Click(object sender, EventAdmin e)
        {
            if (MessageBox.Show(onDeleteMessage, "Supprimer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // call à la BD pour un delete
            }
        }
    }
}
