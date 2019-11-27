using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestPreopterećenjePorazumijevaniArg
    {
        [TestMethod]
        public void ZaPoziveSDvaArgumentaSeIzvodiPreopterećenaMetodaSDvaArgumenta()
        {
            Assert.IsNotNull(typeof(PreopterećenjePodrazumijevaniArg).GetMethod("Zbroji", new Type[] { typeof(int), typeof(int) }));

            Assert.AreEqual(11, PreopterećenjePodrazumijevaniArg.Zbroji(5, 6));
            Assert.AreEqual(1, PreopterećenjePodrazumijevaniArg.Zbroji(1, 0));
        }

        [TestMethod]
        public void ZaPoziveSJednimArgumentomSeIzvodiPreopterećenaMetodaSTriArgumentaSPodrazumijevanimVrijednostima()
        {
            Assert.IsNotNull(typeof(PreopterećenjePodrazumijevaniArg).GetMethod("Zbroji", new Type[] { typeof(int), typeof(int) }));

            Assert.AreEqual(10, PreopterećenjePodrazumijevaniArg.Zbroji(5));
            Assert.AreEqual(6, PreopterećenjePodrazumijevaniArg.Zbroji(1));
        }

        [TestMethod]
        public void ZaPoziveSTriArgumentaSeIzvodiPreopterećenaMetodaSTriArgumentaSPodrazumijevanimVrijednostima()
        {
            Assert.IsNotNull(typeof(PreopterećenjePodrazumijevaniArg).GetMethod("Zbroji", new Type[] { typeof(int), typeof(int) }));

            Assert.AreEqual(35, PreopterećenjePodrazumijevaniArg.Zbroji(5, 10, 20));
            Assert.AreEqual(3, PreopterećenjePodrazumijevaniArg.Zbroji(1, 1, 1));
        }
    }
}
