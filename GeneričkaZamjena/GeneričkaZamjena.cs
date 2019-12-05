using System;

namespace Vsite.CSharp.Metode
{
    class GeneričkaZamjena
    {
        // TODO:070 Definirati javno dostupnu statičku generičku metodu Zamijeni<T>, koja će biti parametrizirana tipom T i moći raditi tipski sigurnu zamjenu bilo koja dva objekta istog tipa.


        private static void Zamjeni<T>(ref T prvi, ref T drugi)
        {
            Console.WriteLine("{0} - {1}", prvi.ToString(), drugi.ToString());
        }

        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 10;
           Zamjeni(ref i1, ref i2);
            // TODO:071 Dodati poziv metode Zamijeni<T> za i1 i i2, pokrenuti program i provjeriti ispis.

            Zamjeni(ref i1, ref i2);

            Console.WriteLine();

            double d1 = 1.23;
            double d2 = 4.56;
           Zamjeni(ref d1, ref d2);
            // TODO:072 Dodati poziv metode Zamijeni<T> za d1 i d2, pokrenuti program i provjeriti ispis.

            Zamjeni(ref d1, ref d2);

            Console.WriteLine();

            string s1 = "Ivica";
            string s2 = "Marica";
           Zamjeni(ref s1,ref  s2);
            // TODO:073 Dodati poziv metode Zamijeni<T> za s1 i s2, pokrenuti program i provjeriti ispis.

            Zamjeni(ref s1, ref s2);

            // TODO:074 Pokrenuti i provjeriti testove (3 testa "GeneričkaZamjena_..." moraju proći).

            // TODO:075 Pogledati generirani kod metode Zamijeni alatom ILDASM.

            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
