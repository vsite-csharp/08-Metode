namespace Vsite.CSharp.Metode
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
            InicijalizirajBrojNaDeset(out int x);
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            while (true)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                // 051 Dodati poziv metode int.TryParse koja će upisani znakovni niz
                // pretvoriti u cijeli broj i vratiti to kao rezultat metode UčitavanjeCijelogBroja.
                string unos=Console.ReadLine();
                if(int.TryParse(unos, out int rezultat))
                {
                    return rezultat;
                }
                return 0;
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
