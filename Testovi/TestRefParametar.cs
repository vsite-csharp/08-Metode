using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    using Osoba = Vsite.CSharp.Metode.Klasa.Osoba;

    [TestClass]
    public class TestRefParametar
    {
        [TestMethod]
        public void MetodaDodajDesetUvećavaProslijeđeniCijeliBroj()
        {
            Assert.AreEqual(15, RefParametar.PozivMetodeDodajDeset(5));
        }

        [TestMethod]
        public void MetodaPromijeniOsobuDoistaMijenjaProslijeđenuOsobu()
        {
            Osoba novaOsoba = RefParametar.PozivMetodePromijeniOsobu(new Osoba("Janko", 1), "Pero", 12);
            Assert.AreEqual("Pero", novaOsoba.Ime);
            Assert.AreEqual(12, novaOsoba.MatičniBroj);
        }
    }
}
