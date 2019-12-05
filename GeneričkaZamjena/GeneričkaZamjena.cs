﻿using System;

namespace Vsite.CSharp.Metode
{
    class GeneričkaZamjena
    {
        // TODO:070 Definirati javno dostupnu statičku generičku metodu Zamijeni<T>, koja će biti parametrizirana tipom T i moći raditi tipski sigurnu zamjenu bilo koja dva objekta istog tipa.
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
            Zamijeni<int>(ref i1, ref i2);
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

            // TODO:074 Pokrenuti i provjeriti testove (3 testa "GeneričkaZamjena_..." moraju proći).

            // TODO:075 Pogledati generirani kod metode Zamijeni alatom ILDASM.

            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
