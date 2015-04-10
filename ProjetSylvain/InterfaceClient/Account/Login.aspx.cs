using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Backend;
using Backend.Interfaces.Implementations;

namespace InterfaceClient.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) // Seulement si la validation a bien marché
            {
                string code = UserName.Text;
                string pass = Password.Text;
                Backend.Login loginObj = Facade.ServiceLogin.FindByCodeAndPass(code, pass, true); // On prend le login de la base de données
                
                if (loginObj != null) // Si le login est correct, on le store dans la session
                {
                    Session["login"] = loginObj;
                    Response.Redirect("~/Default.aspx");
                }

            }
            

        }
    }
}