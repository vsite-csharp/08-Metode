using System;
using System.Reflection.Metadata.Ecma335;

namespace Vsite.CSharp.Metode
{
    class OutParametar
    {
        // Dodati parametru metode modifikator out te promijeniti metodu PozivInicijalizacijeOutParametrom tako da se može prevesti i izvesti.
        static void InicijalizirajBrojNaDeset(out int x)
        {
            x = 10;
        }

        public static void PozivInicijalizacijeOutParametrom()
        {
            int x = 0;
            InicijalizirajBrojNaDeset(out x);
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            while (true)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                // Dodati poziv metode int.TryParse koja će upisani znakovni niz pretvoriti u cijeli broj i vratiti to kao rezultat metode UčitavanjeCijelogBroja.
                int.TryParse(Console.ReadLine(), out int rez);
                return rez;
            }
        }

        // Pokrenuti i provjeriti testove (oba testa u grupi TestOutParametar moraju proći).
        static void Main(string[] args)
        {
            PozivInicijalizacijeOutParametrom();

            UčitavanjeCijelogBroja();
        }
    }
}
