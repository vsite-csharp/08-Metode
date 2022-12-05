using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestOutParametar : ConsoleTest
    {
        [TestMethod]
        public void InicijalizirajBrojNaDesetPostavljaArgumentNa10()
        {
            OutParametar.PozivInicijalizacijeOutParametrom();
            Assert.AreEqual("Nakon InicijalizirajBrojNaDeset: 10", cw?.GetString());
        }

        [TestMethod]
        public void MetodaUčitavanjeCijelogBrojaVraćaCjelobrojnuPrezentacijuUpisanogNiza()
        {
            cr?.Push("3");
            Assert.AreEqual(3, OutParametar.UčitavanjeCijelogBroja());
            cr?.Push("24");
            Assert.AreEqual(24, OutParametar.UčitavanjeCijelogBroja());
        }
    }
}
