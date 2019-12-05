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
            bool ponavljaj = true;
            while (ponavljaj)
            {
                string text = Console.ReadLine(); 
                Console.WriteLine("Upiši neki cijeli broj:");
                
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
