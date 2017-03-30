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
        public void TestAjoutok()
        {
            ctrl.AjoutClient("Robert", "Francky", "francky@gmail.com", null);
            Assert.AreEqual("Robert", ctrl.GetClients().Last().Nom);
        }
    }
}
