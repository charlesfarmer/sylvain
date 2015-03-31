using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend;
using Backend.Services.Interfaces;
using Backend.Services.Implementations;

namespace TestBackend.Services
{
    [TestClass]
    public class TServiceCoordonnees : TService
    {
        IServiceCoordonnees sc = new ServiceCoordonnees();

        [TestMethod]
        public void TestCreate()
        {
            // Data
            Coordonnees c = new Coordonnees()
            {
                Nom         = "nom",
                Prenom      = "prénom",
                Adresse     = "1234 adresse", 
                Telephone   = "1234567890"
            };
            c = sc.Add(c);
            
            // Test: id should not be null after INSERT statement
            Assert.IsInstanceOfType(c.Id, typeof(int));

            // Cleanup
            sc.Delete(c.Id);
        }

        [TestMethod]
        public void TestRead()
        {
            // Data
            Coordonnees c2;
            Coordonnees c = new Coordonnees()
            {
                Nom = "nom",
                Prenom = "prénom",
                Adresse = "1234 adresse",
                Telephone = "1234567890"
            };

            c = sc.Add(c);
            c2 = sc.Get(c.Id);

            // Test: c2 and c should have the same id
            Assert.AreEqual(c2.Id, c.Id);

            // Cleanup
            sc.Delete(c.Id);
        }

        [TestMethod]
        public void TestUpdate()
        {
            // Data
            string nouveauNom = "nom2";
            Coordonnees c2;
            Coordonnees c = new Coordonnees()
            {
                Nom = "nom",
                Prenom = "prénom",
                Adresse = "1234 adresse",
                Telephone = "1234567890"
            };

            c = sc.Add(c);
            c.Nom = nouveauNom;
            sc.Update(c);
            c2 = sc.Get(c.Id);

            // Test: c should have his second
            Assert.AreEqual(c2.Nom, nouveauNom);

            // Cleanup
            sc.Delete(c.Id);
        }

        [TestMethod]
        public void TestDelete()
        {
            // Data
            int id;
            Coordonnees c = new Coordonnees()
            {
                Nom = "nom",
                Prenom = "prénom",
                Adresse = "1234 adresse",
                Telephone = "1234567890"
            };
            c = sc.Add(c);
            id = c.Id;

            sc.Delete(id);

            // Test: Getting an inexistant id should return null
            Assert.IsNull(sc.Get(id));
        }
    }
}
