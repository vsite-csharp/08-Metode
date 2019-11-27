using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestVirtualnihMetoda : ConsoleTest
    {
        [TestMethod]
        public void ZasebniPoziviNevirtualnihMetodaPozivajuMetodeIzOdgovarajućeKlase()
        {
            VirtualneMetode.ZasebniPoziviNevirtualnihMetoda();
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Izvedena1 Obično", cw.GetString());
            Assert.AreEqual("Izvedena2 Obično", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void PoziviNevirtualnihMetodaNaKolekcijiBaznogTipaPozivajuMetodeIzBazneKlase()
        {
            Assert.AreEqual(typeof(Izvedena1), typeof(Izvedena1).GetMethod("IspišiImeObično").DeclaringType);
            Assert.AreEqual(typeof(Izvedena2), typeof(Izvedena2).GetMethod("IspišiImeObično").DeclaringType);

            VirtualneMetode.PoziviNevirtualnihMetodaNaKolekcijiBaznogTipa();
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void ZasebniPoziviVirtualnihMetodaPozivajuMetodeIzOdogovarajućeKlase()
        {
            VirtualneMetode.ZasebniPoziviVirtualnihMetoda();
            Assert.AreEqual("Bazna Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena1 Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena2 Virtualno", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void PoziviVirtualnihMetodaNaKolekcijiBaznogTipaPozivajuMetodeIzOdogovarajućeKlase()
        {
            VirtualneMetode.PoziviVirtualnihMetodaNaKolekcijiBaznogTipa();
            Assert.AreEqual("Bazna Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena1 Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena2 Virtualno", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }
    }
}
