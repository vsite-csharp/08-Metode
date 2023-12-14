namespace Vsite.CSharp.Metode
{
    static class GeneričkaZamjena
    {
        // DID_IT:070 Definirati javno dostupnu statičku generičku metodu Zamijeni<T>, koja će biti parametrizirana tipom T i moći raditi tipski sigurnu zamjenu bilo koja dva objekta istog tipa.
        public static void Zamjeni<T>(ref T prvi, ref T drugi)
        {
            T temp = prvi;
            prvi = drugi;
            drugi = temp;
        }

        private static void IspišiPar(object o1, object o2)
        {
            Console.WriteLine($"{o1.ToString()} - {o2.ToString()}");
        }

        static void Main()
        {
            int i1 = 5;
            int i2 = 10;
            IspišiPar(i1, i2);
            // DID_IT:071 Dodati poziv metode Zamijeni<T> za i1 i i2, pokrenuti program i provjeriti ispis.
            Zamjeni<int>(ref i1, ref i2);
            IspišiPar(i1, i2);

            Console.WriteLine();

            double d1 = 1.23;
            double d2 = 4.56;
            IspišiPar(d1, d2);
            // DID_IT:072 Dodati poziv metode Zamijeni<T> za d1 i d2, pokrenuti program i provjeriti ispis.
            Zamjeni(ref d1, ref d2);
            IspišiPar(d1, d2);

            Console.WriteLine();

            string s1 = "Ivica";
            string s2 = "Marica";
            IspišiPar(s1, s2);
            // DID_IT:073 Dodati poziv metode Zamijeni<T> za s1 i s2, pokrenuti program i provjeriti ispis.
            Zamjeni(ref s1, ref s2);
            IspišiPar(s1, s2);

            // DID_IT:074 Pokrenuti i provjeriti testove (3 testa u grupi TestGeneričkeZamjene moraju proći).

            // DID_IT:075 Pogledati generirani kod metode Zamijeni alatom ILDASM.

        }
    }
}
