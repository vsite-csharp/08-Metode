namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestParams
    {
        [TestMethod]
        public void MetodaZbrojiZaSamoJedanArgumentVraćaTajBroj()
        {
            Assert.AreEqual(1, Params.Zbroji(1));
        }

        [TestMethod]
        public void MetodaZbrojiZaDvaArgumentVraćaNjihovZbroj()
        {
            Assert.AreEqual(3, Params.Zbroji(1, 2));
        }

        [TestMethod]
        public void MetodaZbrojiZaProizvoljniBrojArgumenataVraćaNjihovZbroj()
        {
            Assert.AreEqual(15, Params.Zbroji(1, 2, 3, 4, 5));
        }
    }
}
