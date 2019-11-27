using System;

namespace Vsite.CSharp.Metode
{
    class GenerickaZamjena
    {
        // TODO:070 Definirati javno dostupnu statičku generičku metodu Zamijeni<T>, koja će biti parametrizirana tipom T i moći raditi tipski sigurnu zamjenu bilo koja dva objekta istog tipa.


        private static void IspišiPar(object o1, object o2)
        {
            Console.WriteLine($"{o1.ToString()} - {o2.ToString()}");
        }

        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 10;
            IspišiPar(i1, i2);
            // TODO:071 Dodati poziv metode Zamijeni<T> za i1 i i2, pokrenuti program i provjeriti ispis.

            IspišiPar(i1, i2);

            Console.WriteLine();

            double d1 = 1.23;
            double d2 = 4.56;
            IspišiPar(d1, d2);
            // TODO:072 Dodati poziv metode Zamijeni<T> za d1 i d2, pokrenuti program i provjeriti ispis.

            IspišiPar(d1, d2);

            Console.WriteLine();

            string s1 = "Ivica";
            string s2 = "Marica";
            IspišiPar(s1, s2);
            // TODO:073 Dodati poziv metode Zamijeni<T> za s1 i s2, pokrenuti program i provjeriti ispis.

            IspišiPar(s1, s2);

            // TODO:074 Pokrenuti i provjeriti testove (3 testa u grupi TestGeneričkeZamjene moraju proći).

            // TODO:075 Pogledati generirani kod metode Zamijeni alatom ILDASM.

            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
