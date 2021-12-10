﻿using System;

namespace Vsite.CSharp.Metode
{

    class Params
    {
        // :110 Napisati implementaciju metode tako da vrati zbroj svih proslijeđenih argumenata. Pokrenuti program i provjeriti rezultate.
        public static double Zbroji(params double[] pribrojnici)
        {
            var zbroj = 0.0;
            foreach (var value in pribrojnici)
                zbroj += value;
            return zbroj;
        }

        // :111 Pokrenuti i provjeriti testove (3 testa u grupi TestParams moraju proći).

        static void Main(string[] args)
        {
            double zbroj = Zbroji(1, 2, 3, 4);
            Console.WriteLine(zbroj);

            Console.WriteLine(Zbroji(3.2, 4.3, 7.5));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

    }
}
