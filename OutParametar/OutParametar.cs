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
            InicijalizirajBrojNaDeset(out int x);
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            do
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                string text = Console.ReadLine();

                if (!int.TryParse(text, out int rezultat))
                    continue;
                return rezultat;
            } while (true);
        }

        static void Main(string[] args)
        {
            PozivInicijalizacijeOutParametrom();

            UčitavanjeCijelogBroja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
