using System;

namespace Vsite.CSharp.Metode
{
    using Osoba = Vsite.CSharp.Metode.Klasa.Osoba;

    class RefParametar
    {
        static void DodajDeset(int x)
        {
            x += 10;
        }

        public static int PozivMetodeDodajDeset(int broj)
        {
            Console.WriteLine($"Prije metode DodajDeset: {broj}");
            DodajDeset( broj);
            Console.WriteLine($"Nakon metode DodajDeset: {broj}");
            return broj;
        }

        static void PromijeniOsobu(Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            osoba = new Osoba(novoIme, noviMatičniBroj);
        }

        public static Osoba PozivMetodePromijeniOsobu(Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            Console.WriteLine($"Prije metode PromijeniOsobu: {osoba}");
            PromijeniOsobu( osoba, novoIme, noviMatičniBroj);
            Console.WriteLine($"Nakon metode PromijeniOsobu: {osoba}");
            return osoba;
        }


        static void Main(string[] args)
        {
            PozivMetodeDodajDeset(5);

            PozivMetodePromijeniOsobu(new Osoba("Janko", 1), "Pero", 12);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

    }
}
