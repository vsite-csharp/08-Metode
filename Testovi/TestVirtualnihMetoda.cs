using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestVirtualnihMetoda : ConsoleTest
    {
        [TestMethod]
        public void PozivNevirtualneMetodeUvijekPozivaMetoduIzDeklariraneKlaseBazna()
        {
            Assert.AreEqual(typeof(Izvedena1).GetMethod("IspišiImeObično")?.DeclaringType, typeof(Izvedena1));
            Assert.AreEqual(typeof(Izvedena2).GetMethod("IspišiImeObično")?.DeclaringType, typeof(Izvedena2));

            Bazna b = new Bazna();
            b.IspišiImeObično();
            b = new Izvedena1();
            b.IspišiImeObično();
            b = new Izvedena2();
            b.IspišiImeObično();
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PozivNevirtualneMetodeUIzvedena1PozivaMetoduIzDeklariraneKlaseBazna()
        {
            Assert.AreEqual(typeof(Izvedena1).GetMethod("IspišiImeObično")?.DeclaringType, typeof(Izvedena1));

            Bazna b = new Izvedena1();
            b.IspišiImeObično();
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PozivNevirtualneMetodeUIzvedena2PozivaMetoduIzDeklariraneKlaseBazna()
        {
            Assert.AreEqual(typeof(Izvedena2).GetMethod("IspišiImeObično")?.DeclaringType, typeof(Izvedena2));

            Bazna b = new Izvedena2();
            b.IspišiImeObično();
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PozivNevirtualneMetodeUIzvedena2PozivaMetoduIzDeklariraneKlaseIzvedena1()
        {
            Assert.AreEqual(typeof(Izvedena2).GetMethod("IspišiImeObično")?.DeclaringType, typeof(Izvedena2));

            Izvedena1 i1 = new Izvedena2();
            i1.IspišiImeObično();
            Assert.AreEqual("Izvedena1 Obično", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PozivNevirtualneMetodePozivaMetoduIzDeklariraneKlaseIzvedena2()
        {
            Assert.AreEqual(typeof(Izvedena2).GetMethod("IspišiImeObično")?.DeclaringType, typeof(Izvedena2));

            Izvedena2 i2 = new Izvedena2();
            i2.IspišiImeObično();
            Assert.AreEqual("Izvedena2 Obično", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PozivVirtualneMetodeUIzvedena1PozivaMetoduIzDotičneKlaseČakIKadaJePridruženaBaznomTipu()
        {
            Bazna b = new Bazna();
            b.IspišiImeVirtualno();
            b = new Izvedena1();
            b.IspišiImeVirtualno();
            Assert.AreEqual("Bazna Virtualno", cw?.GetString());
            Assert.AreEqual("Izvedena1 Virtualno", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PozivVirtualneMetodeUIzvedena2PozivaMetoduIzDotičneKlaseČakIKadaJePridruženaBaznomTipu()
        {
            Bazna b = new Bazna();
            b.IspišiImeVirtualno();
            b = new Izvedena2();
            b.IspišiImeVirtualno();
            Assert.AreEqual("Bazna Virtualno", cw?.GetString());
            Assert.AreEqual("Izvedena2 Virtualno", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PoziviNevirtualnihMetodaPozivajuMetodeIzDeklariraneKlase()
        {
            VirtualneMetode.PoziviNevirtualnihMetoda();
            cw?.GetString();
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Izvedena1 Obično", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Izvedena2 Obično", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Bazna Obično", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }

        [TestMethod]
        public void PoziviVirtualnihMetodaPozivajuMetodeIzKonkretneKlase()
        {
            VirtualneMetode.PoziviVirtualnihMetoda();
            cw?.GetString();
            Assert.AreEqual("Bazna Virtualno", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Izvedena1 Virtualno", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Izvedena2 Virtualno", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Izvedena1 Virtualno", cw?.GetString());
            cw?.GetString();
            Assert.AreEqual("Izvedena2 Virtualno", cw?.GetString());
            Assert.IsTrue(cw?.IsEmpty);
        }
    }
}
