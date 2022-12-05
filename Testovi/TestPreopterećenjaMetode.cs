using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public class TestPreopterećenjaMetode : ConsoleTest
    {
        [TestMethod]
        public void PozivSArgumentimaDoubleDoublePozivaMetoduSArgumentimaDoubleDouble()
        {
            var mojeMetode = typeof(Preopterećenje).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Where(mi => mi.Name == "MojaMetoda");
            Assert.AreEqual(2, mojeMetode.Count());
            Assert.IsTrue(mojeMetode.All(mi => mi.GetParameters().Count() == 2));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(double) && mi.GetParameters()[1].ParameterType == typeof(double)));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(int) && mi.GetParameters()[1].ParameterType == typeof(double)));

            double d1 = 1.2;
            double d2 = 3.4;
            Preopterećenje.MojaMetoda(d1, d2);
            Assert.AreEqual($"MojaMetoda(double {d1}, double {d2})", cw?.GetString());
        }

        [TestMethod]
        public void PozivSArgumentimaIntIntPozivaMetoduSParametrimaIntDouble()
        {
            var mojeMetode = typeof(Preopterećenje).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Where(mi => mi.Name == "MojaMetoda");
            Assert.AreEqual(2, mojeMetode.Count());
            Assert.IsTrue(mojeMetode.All(mi => mi.GetParameters().Count() == 2));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(double) && mi.GetParameters()[1].ParameterType == typeof(double)));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(int) && mi.GetParameters()[1].ParameterType == typeof(double)));

            int i1 = 1;
            int i2 = 2;
            Preopterećenje.MojaMetoda(i1, i2);
            Assert.AreEqual($"MojaMetoda(int {i1}, double {i2})", cw?.GetString());
        }

        [TestMethod]
        public void PozivSArgumentimaIntDoublePozivaMetoduSArgumentimaIntDouble()
        {
            var mojeMetode = typeof(Preopterećenje).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Where(mi => mi.Name == "MojaMetoda");
            Assert.AreEqual(2, mojeMetode.Count());
            Assert.IsTrue(mojeMetode.All(mi => mi.GetParameters().Count() == 2));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(double) && mi.GetParameters()[1].ParameterType == typeof(double)));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(int) && mi.GetParameters()[1].ParameterType == typeof(double)));

            int i1 = 1;
            double d2 = 3.4;
            Preopterećenje.MojaMetoda(i1, d2);
            Assert.AreEqual($"MojaMetoda(int {i1}, double {d2})", cw?.GetString());
        }

        [TestMethod]
        public void PozivSArgumentimaDoubleIntPozivaMetoduSArgumentimaDoubleDouble()
        {
            var mojeMetode = typeof(Preopterećenje).GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Where(mi => mi.Name == "MojaMetoda");
            Assert.AreEqual(2, mojeMetode.Count());
            Assert.IsTrue(mojeMetode.All(mi => mi.GetParameters().Count() == 2));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(double) && mi.GetParameters()[1].ParameterType == typeof(double)));
            Assert.IsTrue(mojeMetode.Any(mi => mi.GetParameters()[0].ParameterType == typeof(int) && mi.GetParameters()[1].ParameterType == typeof(double)));

            double d1 = 3.4;
            int i2 = 1;
            Preopterećenje.MojaMetoda(d1, i2);
            Assert.AreEqual($"MojaMetoda(double {d1}, double {i2})", cw?.GetString());
        }
    }
}
