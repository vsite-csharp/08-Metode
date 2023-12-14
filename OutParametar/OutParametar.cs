﻿namespace Vsite.CSharp.Metode
{
    static class OutParametar
    {
        // 050 Dodati parametru metode modifikator out te promijeniti metodu PozivInicijalizacijeOutParametrom tako da se može prevesti i izvesti.
        static void InicijalizirajBrojNaDeset(out int x)
        {
            x = 10;
        }

        public static void PozivInicijalizacijeOutParametrom()
        {
            //int x = 0;
            InicijalizirajBrojNaDeset(out int x);
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            while (true)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                string unos = Console.ReadLine();
                // 051 Dodati poziv metode int.TryParse koja će upisani znakovni niz pretvoriti u cijeli broj i vratiti to kao rezultat metode UčitavanjeCijelogBroja.
                if(int.TryParse(unos, out int result))
                    return result;
                
            }
        }

        // 052 Pokrenuti i provjeriti testove (oba testa u grupi TestOutParametar moraju proći).
        static void Main()
        {
            PozivInicijalizacijeOutParametrom();

            Console.WriteLine($"Upisan je broj: {UčitavanjeCijelogBroja()}");
        }
    }
}
