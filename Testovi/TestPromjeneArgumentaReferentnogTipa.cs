using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestPromjeneArgumentaReferentnogTipa : ConsoleTest
    {
        [TestMethod]
        public void NakonIzlaskaIzMetodeObjektJeNepromijenjenAliSeNjegovSadržajMožePromijeniti()
        {
            ReferentniTipKaoParametar.PromjenaArgumentaReferentnogTipa();
            Assert.AreEqual(9, cw?.Count);
            Assert.AreEqual("Ime: Janko, MB: 1", cw?.GetString());
            Assert.AreEqual("U metodi ZamijeniOsobuMirkom stavljam novu osobu:", cw?.GetString());
            Assert.AreEqual("Ime: Mirko, MB: 2", cw?.GetString());
            Assert.AreEqual("Nakon povratka iz metode ZamijeniOsobuMirkom:", cw?.GetString());
            Assert.AreEqual("Ime: Janko, MB: 1", cw?.GetString());

            Assert.AreEqual("U metodi PromijeniIme mijenjam ime u Pero", cw?.GetString());
            Assert.AreEqual("Ime: Pero, MB: 1", cw?.GetString());
            Assert.AreEqual("Nakon povratka iz metode PromijeniIMe:", cw?.GetString());
            Assert.AreEqual("Ime: Pero, MB: 1", cw?.GetString());
        }
    }
}
