using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestMetodeProširenja
    {
        [TestMethod]
        public void MetodaBrojRiječiVraćaBrojRiječiOdvojenihPoJednomBjelinom()
        {
            string s = "udovica baci vodu";
            Assert.AreEqual(3, MetodeProširenja.DajBrojRiječi(s));
        }

        [TestMethod]
        public void MetodaBrojRiječiVraćaBrojRiječiOvojenihSVišestrukimBjelinama()
        {
            string s = "udovica    baci   vodu";
            Assert.AreEqual(3, MetodeProširenja.DajBrojRiječi(s));
        }

        [TestMethod]
        public void MetodaBrojRiječiVraćaBrojRiječiOdvojenihInterpunkcijom()
        {
            string s = "jedan.Dva,tri,četiri";
            Assert.AreEqual(4, MetodeProširenja.DajBrojRiječi(s));
        }

        [TestMethod]
        public void MetodaBrojRiječiVraćaBrojRiječiOdvojenihInterpunkcijomIBjelinama()
        {
            string s = "jedan. Dva, tri, četiri";
            Assert.AreEqual(4, MetodeProširenja.DajBrojRiječi(s));
        }
    }
}
