using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestPromjeneArgumentaVrijednosnogTipa : ConsoleTest
    {
        [TestMethod]
        public void NakonIzlaskaIzMetodeObjektJeNepromijenjen()
        {
            VrijednosniTipKaoParametar.PromjenaArgumentaVrijednosnogTipa();
            Assert.AreEqual(9, cw?.Count);
            Assert.AreEqual("Ime: Janko, MB: 1", cw?.GetString());
            Assert.AreEqual("U metodi ZamijeniOsobuDarkom stavljam novu osobu:", cw?.GetString());
            Assert.AreEqual("Ime: Darko, MB: 2", cw?.GetString());
            Assert.AreEqual("Nakon povratka iz metode ZamijeniOsobuDarkom:", cw?.GetString());
            Assert.AreEqual("Ime: Janko, MB: 1", cw?.GetString());

            Assert.AreEqual("U metodi PromijeniIme mijenjam ime u Pero", cw?.GetString());
            Assert.AreEqual("Ime: Pero, MB: 1", cw?.GetString());
            Assert.AreEqual("Nakon povratka iz metode PromijeniIMe:", cw?.GetString());
            Assert.AreEqual("Ime: Janko, MB: 1", cw?.GetString());
        }
    }
}
