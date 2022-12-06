using System;

namespace Vsite.CSharp.Metode
{
    class OutParametar
    {
        // TODO:050 Dodati parametru metode modifikator out te promijeniti metodu PozivInicijalizacijeOutParametrom tako da se može prevesti i izvesti.
        static void InicijalizirajBrojNaDeset(int x)
        {
            x = 10;
        }

        public static void PozivInicijalizacijeOutParametrom()
        {
            int x = 0;
            InicijalizirajBrojNaDeset(x);
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            while (true)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                // TODO:051 Dodati poziv metode int.TryParse koja će upisani znakovni niz pretvoriti u cijeli broj i vratiti to kao rezultat metode UčitavanjeCijelogBroja.

                return 0;
            }
        }

        // TODO:052 Pokrenuti i provjeriti testove (oba testa u grupi TestOutParametar moraju proći).
        static void Main(string[] args)
        {
            PozivInicijalizacijeOutParametrom();

            UčitavanjeCijelogBroja();
        }
    }
}
