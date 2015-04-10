using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Backend;

namespace InterfaceClient
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["login"] == null) // Si l'utilisateur n'est pas authentifié
            {
                if (!(Page.Title.Equals("Connexion") || Page.Title.Equals("Inscription"))) // S'il n'est ni sur Connexion ou inscription
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
            }
            else
            {
                var currentUser = Session["login"] as Backend.Login; // Je m'assure que le login est bien du bon type

                if (Page.Title.Equals("Connexion") || Page.Title.Equals("Inscription")) //Si il est connecté, il ne devrait pas être sur une de ces pages
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Disconnect(object sender, EventArgs e)
        {
            Session["login"] = null;
            Response.Redirect("~/Account/Login.aspx");
        }
    }
}