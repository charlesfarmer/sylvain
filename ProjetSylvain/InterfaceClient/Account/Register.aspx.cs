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
            if (Page.IsValid)// Exécuter seulement si les champs sont bien remplis
            {
                if (Facade.ServiceLogin.FindByCode(UserName.Text) != null)// Si le code existe déjà, on cancel l'inscription
                {
                    return;
                }
                // Création des objets à ajouter
                Backend.Login loginObj = new Backend.Login();
                Backend.Etudiant etudiantObj = new Backend.Etudiant();
                Backend.Coordonnees coordonneesObj = new Backend.Coordonnees();

                // Remplir les infos de l'objet Login
                loginObj.Code = UserName.Text;
                loginObj.Mot_de_Passe = Password.Text;
                loginObj.IsAdmin = false;
                loginObj = Facade.ServiceLogin.Add(loginObj);// Envoyer l'objet à la base de données

                // Remplir les infos de l'objet Coordonnees
                coordonneesObj.Adresse = Adresse.Text;
                coordonneesObj.Telephone = Tel.Text;
                coordonneesObj.Nom = Nom.Text;
                coordonneesObj.Prenom = Prenom.Text;
                coordonneesObj = Facade.ServiceCoordonnees.Add(coordonneesObj);// Envoyer l'objet à la base de données

                etudiantObj = Facade.ServiceEtudiant.AddNewEtudiant(coordonneesObj.Id, loginObj.Id);// Création de l'étudiant dans le backend
                Session["login"] = etudiantObj.Login;// Ajouter le login nouvellement créé à la session, pour le logger in
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}