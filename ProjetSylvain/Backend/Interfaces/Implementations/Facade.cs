using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Interfaces.Interfaces;
using Backend;
using Backend.Services.Interfaces;
using Backend.Services.Implementations;

namespace Backend.Interfaces.Implementations
{

    public class Facade : IFacade
    {
		

		#region methode 
		public static IServiceJour ServiceJour
		{
			get
			{
				return new ServiceJour();
			}
		}

		public static IServiceEtudiant ServiceEtudiant
		{
			get
			{
				return new ServiceEtudiant();
			}
		}

		public static IServiceHeure ServiceHeure
		{
			get
			{
				return new ServiceHeure();
			}
		}

		public static IServiceInscription ServiceInscription
		{
			get
			{
				return new ServiceInscription();
			}
		}

		public static IServiceLogin ServiceLogin
		{
			get
			{
				return new ServiceLogin();
			}
		}

		public static IServiceProfesseur ServiceProfesseur
		{
			get
			{
				return new ServiceProfesseur();
			}
		}

		public static IServicePaiement ServicePaiement
		{
			get
			{
				return new ServicePaiement();
			}
		}

		public static IServiceCoordonnees ServiceCoordonnees 
		{
			get
			{
				return new ServiceCoordonnees();
			}
		}

		public static IServiceCours ServiceCours
		{
			get
			{
				return new ServiceCours();
			}
		}
		
		public static IServiceCoursHoraire ServiceCoursHoraire
		{
			get
			{
				return new ServiceCoursHoraire();
			}
		}
		
		public static IServiceProfesseurHoraire ServiceProfesseurHoraire
		{
			get
			{
				return new ServiceProfesseurHoraire();
			}
		}
		
		public static IServiceSujet ServiceSujet
		{
			get
			{
				return new ServiceSujet();
			}
		}
		#endregion

		static Facade()
        {
			

        }
    }
}
