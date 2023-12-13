using System.Reflection;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestGeneričkeZamjene
    {
        [TestMethod]
        public void MetodaZamijeniZamjenjujeInt()
        {
            var generičkeMetode = typeof(GeneričkaZamjena).GetMethods().Where(m => m.IsGenericMethod && m.Name == "Zamijeni");
            Assert.AreEqual(1, generičkeMetode.Count());
            var metoda = generičkeMetode.ElementAt(0);
            Assert.IsNotNull(metoda);
            MethodInfo generičkaMetoda = metoda.MakeGenericMethod(typeof(int));
            object[] argumenti = new object[2] { 2, 5 };
            generičkaMetoda.Invoke(null, argumenti);

            Assert.AreEqual(5, argumenti[0]);
            Assert.AreEqual(2, argumenti[1]);
        }

        [TestMethod]
        public void MetodaZamijeniZamjenjujeDouble()
        {
            var generičkeMetode = typeof(GeneričkaZamjena).GetMethods().Where(m => m.IsGenericMethod && m.Name == "Zamijeni");
            Assert.AreEqual(1, generičkeMetode.Count());
            var metoda = generičkeMetode.ElementAt(0);
            MethodInfo generičkaMetoda = metoda.MakeGenericMethod(typeof(double));
            object[] argumenti = new object[2] { 2.34, 5.14 };
            generičkaMetoda.Invoke(null, argumenti);

            Assert.AreEqual(5.14, argumenti[0]);
            Assert.AreEqual(2.34, argumenti[1]);
        }

        [TestMethod]
        public void MetodaZamijeniZamjenjujeString()
        {
            var generičkeMetode = typeof(GeneričkaZamjena).GetMethods().Where(m => m.IsGenericMethod && m.Name == "Zamijeni");
            Assert.AreEqual(1, generičkeMetode.Count());
            var metoda = generičkeMetode.ElementAt(0);
            MethodInfo generičkaMetoda = metoda.MakeGenericMethod(typeof(string));
            object[] argumenti = new object[2] { "Ivica", "Marica" };
            generičkaMetoda.Invoke(null, argumenti);

            Assert.AreEqual("Marica", argumenti[0]);
            Assert.AreEqual("Ivica", argumenti[1]);
        }
    }
}
