using System;

namespace Vsite.CSharp.Metode
{
    class OutParametar
    {
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
            bool ponavljaj = true;
            while (ponavljaj)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                string text = Console.ReadLine();
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
