using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using Backend;
using Backend.Interfaces.Implementations;

namespace InterfaceClient.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RegisterUser(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (Facade.ServiceLogin.FindByCode(UserName.Text) != null)
                {
                    return;
                }
                Backend.Login loginObj = new Backend.Login();
                Backend.Etudiant etudiantObj = new Backend.Etudiant();
                Backend.Coordonnees coordonneesObj = new Backend.Coordonnees();

                loginObj.Code = UserName.Text;
                loginObj.Mot_de_Passe = Password.Text;
                loginObj.IsAdmin = false;
                loginObj = Facade.ServiceLogin.Add(loginObj);

                coordonneesObj.Adresse = Adresse.Text;
                coordonneesObj.Telephone = Tel.Text;
                coordonneesObj.Nom = Nom.Text;
                coordonneesObj.Prenom = Prenom.Text;
                coordonneesObj = Facade.ServiceCoordonnees.Add(coordonneesObj);

                etudiantObj = Facade.ServiceEtudiant.AddNewEtudiant(coordonneesObj.Id, loginObj.Id);
                Session["login"] = etudiantObj.Login;
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}