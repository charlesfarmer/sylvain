using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Backend;
using Backend.Services.Interfaces;
using Backend.Services.Implementations;

namespace InterfaceAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceCoordonnees sc = new ServiceCoordonnees();
            Coordonnees c = new Coordonnees();
            c.Nom = "Farmer";
            c.Prenom = "Charles";
            c.Adresse = "7650 rue Fabre";
            c.Telephone = "514 658 3450";
            c.Etudiant = new Etudiant();
            try
            {
                ((ServiceCoordonnees)sc).add(c);
            }
            catch (Exception e)
            {
                MessageBox.Show("HA-ha\n\n" + e.Message);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());
			//Application.Run(new FormMain());
        }
    }
}
