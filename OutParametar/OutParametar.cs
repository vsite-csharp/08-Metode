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
            while (true)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                int.TryParse(Console.ReadLine(), out int x);
                return x;

            }
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
