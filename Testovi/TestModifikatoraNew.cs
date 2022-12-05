using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestModifikatoraNew : ConsoleTest
    {
        [TestMethod]
        public void PozivMetodePredstaviSeNaBaznojKlasiPozivaMetoduIzBazne()
        {
            Assert.IsTrue(typeof(ModifikatorNew.Izvedena).GetMethod("PredstaviSe")?.DeclaringType == typeof(ModifikatorNew.Izvedena));

            ModifikatorNew.Bazna bazna = new ModifikatorNew.Bazna();
            bazna.PredstaviSe();
            Assert.AreEqual("Bazna klasa", cw?.GetString());
        }

        [TestMethod]
        public void PozivMetodePredstaviSeNaIzvedenojKlasiPridruženojBaznomTipuPozivaMetoduIzBazne()
        {
            Assert.IsTrue(typeof(ModifikatorNew.Izvedena).GetMethod("PredstaviSe")?.DeclaringType == typeof(ModifikatorNew.Izvedena));

            ModifikatorNew.Bazna bazna = new ModifikatorNew.Izvedena();
            bazna.PredstaviSe();
            Assert.AreEqual("Bazna klasa", cw?.GetString());
        }

        [TestMethod]
        public void PozivMetodePredstaviSeNaIzvedenojKlasiPozivaMetoduIzIzvedene()
        {
            ModifikatorNew.Izvedena izvedena = new ModifikatorNew.Izvedena();
            izvedena.PredstaviSe();

            Assert.AreEqual(2, cw?.Count);
            Assert.AreEqual("Izvedena klasa, izvedena iz:", cw?.GetString());
            Assert.AreEqual("Bazna klasa", cw?.GetString());
        }
    }
}
