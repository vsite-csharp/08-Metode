using System;

namespace Vsite.CSharp.Metode
{
    class OutParametar
    {
        // TODO:050 Dodati parametru metode modifikator out te promijeniti metodu PozivInicijalizacijeOutParametrom tako da se može prevesti i izvesti.
        static void InicijalizirajBrojNaDeset(out int x)
        {
            x = 10;
        }

        public static void PozivInicijalizacijeOutParametrom()
        {
       
            InicijalizirajBrojNaDeset( out int x);
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            bool ponavljaj = true;
            while (ponavljaj)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                string text = Console.ReadLine();
                // TODO:051 Dodati poziv metode int.TryParse koja će upisani znakovni niz pretvoriti u cijeli broj i vratiti to kao rezultat metode UčitavanjeCijelogBroja.
                ponavljaj = !int.TryParse(text, out int rezultat);
                if (ponavljaj)
                    continue;
                return rezultat;
            }
            return 0;
        }

        // TODO:052 Pokrenuti i provjeriti testove (2 test "OutParametar_..." moraju proći).

        static void Main(string[] args)
        {

            PozivInicijalizacijeOutParametrom();

            UčitavanjeCijelogBroja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
