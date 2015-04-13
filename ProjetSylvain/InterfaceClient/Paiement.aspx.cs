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
    public partial class About : Page
    {
        protected string type;
        protected decimal prix;
        protected Cours cours;
        protected Etudiant etu;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Type 1: inscription
            //Type 2: continuation de paiement sur inscription déjà existante
            //Type 3: désinscription


            etu = (Session["login"] as Backend.Login).Etudiant;
            type = Request.QueryString["type"];
            int coursId;
            if (!int.TryParse(Request.QueryString["coursId"], out coursId) || type==null)//S'il manque le paramètre coursId ou le type
            {
                Response.Redirect("~/Default.aspx");
                return;
            }

            cours = Facade.ServiceCours.Get(coursId);

            if (type == "1" && cours.Inscription.Any(x => x.Etudiant.Id == etu.Id))// Si c'est une inscription mais qu'il y en a déjà une, ça devient une continuation d'inscription.
            {
                type = "2";
            }

            switch (type)
            {
                case "1":
                    prix = Math.Round((cours.Cout / 10), 3);// Pour une inscription, le cout initial est de 10%
                    break;


                case "2":
                    prix = Math.Round((cours.Cout *0.9m), 3);// Pour la continuation d'inscription, on doit payer le 90% restant.
                    break;


                case "3": // On doit rembourser tous les paiements sauf le premier.
                    foreach (Paiement p in cours.Inscription.Single(x => x.Etudiant.Id == etu.Id).Paiement.OrderBy(x=>x.TimeStamp).Skip(1))
                    {
                        p.Rembourse = true;
                        Facade.ServicePaiement.Update(p);
                        
                    }
                    cours.Inscription.Single(x => x.Etudiant.Id == etu.Id).Annule = true;
                    Facade.ServiceInscription.Update(cours.Inscription.Single(x => x.Etudiant.Id == etu.Id));

                    Response.Redirect("~/Default.aspx");
                    break;
                default:
                    break;
            }

        }

        protected void Pay(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (type == "1")
            {
                Inscription i = Facade.ServiceInscription.AddNewInscription(false, etu.Id, cours.Id);// Création de l'objet inscription dans le backend
                Facade.ServicePaiement.AddNewPaiement(prix, false, DateTime.Now, i.Id);// Création de l'objet paiement dans le backend
                
                Response.Redirect("~/Default.aspx");
            }
            else if (type == "2")
            {
                // Création de l'objet Paiement dans le Backend
                Facade.ServicePaiement.AddNewPaiement(prix, false, DateTime.Now, cours.Inscription.Single(x => x.Etudiant.Id == etu.Id).Id);

                Response.Redirect("~/Default.aspx");
            }
        }
    }
}