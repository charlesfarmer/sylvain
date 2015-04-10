using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Backend;
using Backend.Interfaces.Implementations;

namespace InterfaceClient
{
    public partial class _Default : Page
    {
        protected List<Cours> listeCours;
        protected Etudiant etudiantCourant;
        protected void Page_Load(object sender, EventArgs e)
        {
            listeCours = Facade.ServiceCours.GetAllAvailableForSubscription();
            etudiantCourant = (Session["login"] as Backend.Login).Etudiant;
        }
    }
}