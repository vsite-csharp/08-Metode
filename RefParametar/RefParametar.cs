﻿namespace Vsite.CSharp.Metode
{
    using Osoba = Klasa.Osoba;

    static class RefParametar
    {
        // TODO:040 Dodati parametru metode modifikator ref tako da se argument x metodi prenosi po referenci te promijeniti poziv metode. Pokrenuti program i provjeriti ispis.
        static void DodajDeset(int x)
        {
            x += 10;
        }

        public static int PozivMetodeDodajDeset(int broj)
        {
            Console.WriteLine($"Prije metode DodajDeset: {broj}");
            DodajDeset(broj);
            Console.WriteLine($"Nakon metode DodajDeset: {broj}");
            return broj;
        }

        // TODO:041 Dodati prvom parametru metode modifikator ref tako da se prvi argument osoba metodi prenosi po referenci te promijeniti poziv metode. Pokrenuti program i provjeriti ispis.
        static void PromijeniOsobu(Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            osoba = new Osoba(novoIme, noviMatičniBroj);
        }

        public static Osoba PozivMetodePromijeniOsobu(Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            Console.WriteLine($"Prije metode PromijeniOsobu: {osoba}");
            PromijeniOsobu(osoba, novoIme, noviMatičniBroj);
            Console.WriteLine($"Nakon metode PromijeniOsobu: {osoba}");
            return osoba;
        }

        // TODO:042 Pokrenuti i provjeriti testove (2 testa TestRefParametar moraju proći).
        static void Main()
        {
            PozivMetodeDodajDeset(5);

            PozivMetodePromijeniOsobu(new Osoba("Janko", 1), "Pero", 12);
        }
    }
}
