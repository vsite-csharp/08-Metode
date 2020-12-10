using System;

namespace Vsite.CSharp.Metode
{
    class Preopterećenje
    {
        //Pokrenuti program i provjeriti ispis.
        public static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(double {broj1}, double {broj2})");
        }

        //Napisati statičku javno dostupnu preopterećenu verziju metode MojaMetoda koja prima dva argumenta: prvi tipa int, a drugi tipa double. Metoda mora ispisati $"MojaMetoda(int {broj1}, double {broj2})"
        public static void MojaMetoda(int broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(int {broj1}, double {broj2})");
        }
        //Razmotriti koje će se inačice pozivati. Pokrenuti program i usporediti ispis s prijašnjim.

        //Pokrenuti i provjeriti testove (4 testa "TestPreopterećenjaMetode" moraju proći).


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
