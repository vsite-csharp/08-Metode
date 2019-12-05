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
            bool ponavljaj = true;
            
            while (ponavljaj)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                string text = Console.ReadLine();
                ponavljaj = int.TryParse(text, out int rezultat);
                if (ponavljaj)
                    continue;
                return rezultat;
            }
            return 0;
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
