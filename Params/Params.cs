﻿namespace Vsite.CSharp.Metode
{
    static class Params
    {
        // TODO:110 Napisati implementaciju metode tako da vrati zbroj svih proslijeđenih argumenata. Pokrenuti program i provjeriti rezultate.
        public static double Zbroji(params double[] pribrojnici)
        {
            return 0.0;
        }

        // TODO:111 Pokrenuti i provjeriti testove (3 testa u grupi TestParams moraju proći).

        static void Main()
        {
            double zbroj = Zbroji(1, 2, 3, 4);
            Console.WriteLine(zbroj);

            Console.WriteLine(Zbroji(3.2, 4.3, 7.5));
        }
    }
}
