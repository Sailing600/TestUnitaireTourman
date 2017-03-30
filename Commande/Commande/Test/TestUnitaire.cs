using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using GestionCommande.controleur;
using System.Linq;

namespace Gestioncommande.Test
{
    /// <summary>
    /// Description résumée pour TestUnitaire
    /// </summary>
    [TestClass]
    public class TestUnitaire
    {
        Controleur ctrl = new CommandeControleur();
        [TestMethod]
        public void TestAjoutCok()
        {
            ctrl.AjoutClient("Robert", "Richard", "francky@gmail.com", null);
            Assert.AreEqual("Robert", ctrl.GetClients().Last().Nom);
        }

        [TestMethod]
        public void TestAjoutPko()
        {
            ctrl.AjoutProduit("Costume",2000);
            Assert.AreNotEqual(1200, ctrl.GetProduits().Last().Prix);
        }

        [TestMethod]
        public void TestAjoutPok()
        {
            ctrl.AjoutProduit("Aiguille à tricoter", 20);
            Assert.AreEqual(20, ctrl.GetProduits().Last().Prix);
        }

        [TestMethod]
        public void TestAjoutCko()
        {
            ctrl.AjoutClient("Murdock","Matt","devildar@hell.fr", null);
            Assert.AreNotEqual("john", ctrl.GetClients().Last().Prenom);
        }
    }
}
