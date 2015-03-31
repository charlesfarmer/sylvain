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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (formLogin.DialogResult == DialogResult.Yes)
            {
                Application.Run(new FormMain());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
