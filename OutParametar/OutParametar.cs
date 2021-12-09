using System;

namespace Vsite.CSharp.Metode
{
    class OutParametar
    {
        // 050 Dodati parametru metode modifikator out te promijeniti metodu PozivInicijalizacijeOutParametrom tako da se može prevesti i izvesti.
        static void InicijalizirajBrojNaDeset(out int x) // ne ocekuje inijalizaciju, kao sto ref ocekuje inicializaciju
        {
            x = 10;
        }

        public static void PozivInicijalizacijeOutParametrom()
        {
            //int x = 0; //zasivljeno, ne treba incijalizicija
            InicijalizirajBrojNaDeset(out int x); // deklariras u pozivu funkcije
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            while (true)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                // 051 Dodati poziv metode int.TryParse koja će upisani znakovni niz pretvoriti u cijeli broj i vratiti to kao rezultat metode UčitavanjeCijelogBroja.
                var tekst = Console.ReadLine();
                if (int.TryParse(tekst, out int rezultat))
                {
                    return rezultat;
                }
            }
        }

        // 052 Pokrenuti i provjeriti testove (oba testa u grupi TestOutParametar moraju proći).
        static void Main(string[] args)
        {

            PozivInicijalizacijeOutParametrom();

            UčitavanjeCijelogBroja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
