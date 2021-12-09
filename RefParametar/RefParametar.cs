using System;

namespace Vsite.CSharp.Metode
{
    using Osoba = Vsite.CSharp.Metode.Klasa.Osoba;

    class RefParametar
    {
        // :040 Dodati parametru metode modifikator ref tako da se argument x metodi prenosi po referenci te promijeniti poziv metode. Pokrenuti program i provjeriti ispis.
        static void DodajDeset(ref int x)
        {
            x += 10;
        }

        public static int PozivMetodeDodajDeset(int broj)
        {
            Console.WriteLine($"Prije metode DodajDeset: {broj}");
            DodajDeset(ref broj);
            Console.WriteLine($"Nakon metode DodajDeset: {broj}");
            return broj;
        }

        // TODO:041 Dodati prvom parametru metode modifikator ref tako da se prvi argument osoba metodi prenosi po referenci te promijeniti poziv metode. Pokrenuti program i provjeriti ispis.
        static void PromijeniOsobu(ref Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            osoba = new Osoba(novoIme, noviMatičniBroj);
        }

        public static Osoba PozivMetodePromijeniOsobu(Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            Console.WriteLine($"Prije metode PromijeniOsobu: {osoba}");
            PromijeniOsobu(ref osoba, novoIme, noviMatičniBroj);
            Console.WriteLine($"Nakon metode PromijeniOsobu: {osoba}");
            return osoba;
        }

        // TODO:042 Pokrenuti i provjeriti testove (2 testa TestRefParametar moraju proći).
        static void Main(string[] args)
        {
            PozivMetodeDodajDeset(5);

            PozivMetodePromijeniOsobu(new Osoba("Janko", 1), "Pero", 12);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

    }
}
