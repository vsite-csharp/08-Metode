using System;

namespace Vsite.CSharp.Metode
{
    class Preopterećenje
    {
        // TODO:000 Pokrenuti program i provjeriti ispis.
        public static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(double {broj1}, double {broj2})");
        }

        public static void MojaMetoda(int broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(int {broj1}, double {broj2})");
        }




        static void Main(string[] args)
        {
            int i1 = 1;
            int i2 = 2;
            double d1 = 3;
            double d2 = 4;

            MojaMetoda(i1, i2);
            MojaMetoda(i1, d1);
            MojaMetoda(d1, d2);
            MojaMetoda(d1, i2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
