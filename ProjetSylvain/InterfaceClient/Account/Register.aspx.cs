using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;

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
                Backend.Login loginObj;
                Backend.Etudiant etudiantObj;

                
            }
            
        }
    }
}