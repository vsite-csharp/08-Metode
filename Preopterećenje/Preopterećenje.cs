﻿using System;

namespace Vsite.CSharp.Metode
{
    class Preopterećenje
    {
        // TODO:000 Pokrenuti program i provjeriti ispis.
        public static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(double {broj1}, double {broj2})");
        }

        // TODO:001 Napisati statičku javno dostupnu preopterećenu verziju metode MojaMetoda koja prima dva argumenta: prvi tipa int, a drugi tipa double. Metoda mora ispisati $"MojaMetoda(int {broj1}, double {broj2})"

        // TODO:002 Razmotriti koje će se inačice pozivati. Pokrenuti program i usporediti ispis s prijašnjim.

        // TODO:003 Pokrenuti i provjeriti testove (4 testa "TestPreopterećenjaMetode" moraju proći).


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
        }
    }
}
