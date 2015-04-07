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
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceJour(context);
				}
			}
		}

		public static IServiceEtudiant ServiceEtudiant
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceEtudiant(context);
				}
			}
		}

		public static IServiceHeure ServiceHeure
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceHeure(context);
				}
			}
		}

		public static IServiceInscription ServiceInscription
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceInscription(context);
				}
			}
		}

		public static IServiceLogin ServiceLogin
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceLogin(context);
				}
			}
		}

		public static IServiceProfesseur ServiceProfesseur
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceProfesseur(context);
				}
			}
		}

		public static IServicePaiement ServicePaiement
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServicePaiement(context);
				}
			}
		}

		public static IServiceCoordonnees ServiceCoordonnees 
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceCoordonnees(context);
				}
			}
		}

		public static IServiceCours ServiceCours
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceCours(context);
				}
			}
		}
		
		public static IServiceCoursHoraire ServiceCoursHoraire
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceCoursHoraire(context);
				}
			}
		}
		
		public static IServiceProfesseurHoraire ServiceProfesseurHoraire
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceProfesseurHoraire(context);
				}
			}
		}
		
		public static IServiceSujet ServiceSujet
		{
			get
			{
				using (var context = EntityContainer.getInstance())
				{
					return new ServiceSujet(context);
				}
			}
		}
		#endregion

		static Facade()
        {
			

        }
    }
}
