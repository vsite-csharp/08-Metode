using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestZamjeneObjekata : ConsoleTest
    {
        [TestMethod]
        public void MetodaZamijeniZamjenjuje2Stringa()
        {
            string prvi = "prvi";
            string drugi = "drugi";
            ZamjenaObjekata.ZamjenaStringova(prvi, drugi);
            Assert.AreEqual("Prije metode Zamijeni:", cw?.GetString());
            Assert.AreEqual($"prvi = '{prvi}'", cw?.GetString());
            Assert.AreEqual($"drugi = '{drugi}'", cw?.GetString());
            Assert.AreEqual("Nakon metode Zamijeni:", cw?.GetString());
            Assert.AreEqual($"prvi = '{drugi}'", cw?.GetString());
            Assert.AreEqual($"drugi = '{prvi}'", cw?.GetString());
        }

        [TestMethod]
        public void MetodaZamijeniZamjenjuje2Inta()
        {
            int prvi = 1;
            int drugi = 2;
            ZamjenaObjekata.ZamjenaIntova(prvi, drugi);
            Assert.AreEqual("Prije metode Zamijeni:", cw?.GetString());
            Assert.AreEqual($"prvi = '{prvi}'", cw?.GetString());
            Assert.AreEqual($"drugi = '{drugi}'", cw?.GetString());
            Assert.AreEqual("Nakon metode Zamijeni:", cw?.GetString());
            Assert.AreEqual($"prvi = '{drugi}'", cw?.GetString());
            Assert.AreEqual($"drugi = '{prvi}'", cw?.GetString());
        }
    }
}
