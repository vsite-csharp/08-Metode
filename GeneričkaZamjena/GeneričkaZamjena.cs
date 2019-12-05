using System;

namespace Vsite.CSharp.Metode
{
    class GeneričkaZamjena
    {
     
    public static void Zamijeni<T>(ref T prvi, ref T drugi)
        {
            var temp = prvi;
            prvi = drugi;
            drugi = temp;

        }

        private static void IspišiPar(object o1, object o2)
        {
            Console.WriteLine("{0} - {1}", o1.ToString(), o2.ToString());
        }

        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 10;
            IspišiPar(i1, i2);
            Zamijeni(ref i1, ref i2);
            IspišiPar(i1, i2);

            Console.WriteLine();

            double d1 = 1.23;
            double d2 = 4.56;
            IspišiPar(d1, d2);
            Zamijeni(ref d1, ref d2);
            IspišiPar(d1, d2);

            Console.WriteLine();

            string s1 = "Ivica";
            string s2 = "Marica";
            IspišiPar(s1, s2);
            Zamijeni(ref s1, ref s2);
            IspišiPar(s1, s2);

            

Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
