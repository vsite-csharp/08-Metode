using System;

namespace Vsite.CSharp.Metode
{
    class OutParametar
    {
        // :050 Dodati parametru metode modifikator out te promijeniti metodu PozivInicijalizacijeOutParametrom tako da se može prevesti i izvesti.
        static void InicijalizirajBrojNaDeset(out int x)
        {
            x = 10;
        }
        // kod refa- metodi prosljeđujemo referencu i direktno pristupamo objektu, a ponekad želimo da nam vrati podatak koji nije inicijaliziran prije poziva metode
        //ref kompajler očekuje inicijaizaciju objekta prije poziva metode, a kod out ne

        public static void PozivInicijalizacijeOutParametrom()
        {
            //int x = 0; Nije nam potrebna inicijalizacije, al dole mormao deklarirati tip objekta
            InicijalizirajBrojNaDeset(out int x);
            Console.WriteLine($"Nakon InicijalizirajBrojNaDeset: {x}");
        }

        public static int UčitavanjeCijelogBroja()
        {
            while (true)
            {
                Console.WriteLine("Upiši neki cijeli broj:");
                // :051 Dodati poziv metode int.TryParse koja će upisani znakovni niz pretvoriti u cijeli broj i vratiti to kao rezultat metode UčitavanjeCijelogBroja.
                var tekst = Console.ReadLine();
                if (int.TryParse(tekst, out int rezultat))
                {
                    return rezultat;
                };

                // parse parsira tekst, ako ne uspije baci exception
                //tryparse kada ne želimo da nam baci exception, ako ne može prevesti vraća bool je li uspjela ili nije uspjela, 
                //ako je uspjela vrati kroz drugi parametar rezultat
            }
        }

        // :052 Pokrenuti i provjeriti testove (oba testa u grupi TestOutParametar moraju proći).
        static void Main(string[] args)
        {

            PozivInicijalizacijeOutParametrom();

            UčitavanjeCijelogBroja();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
