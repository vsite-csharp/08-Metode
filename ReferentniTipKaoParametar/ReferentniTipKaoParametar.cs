using System;

namespace Vsite.CSharp.Metode
{
    using Osoba = Klasa.Osoba;

    class ReferentniTipKaoParametar
    {
        private static void ZamijeniOsobuMirkom(Osoba o)
        {
            Console.WriteLine("U metodi ZamijeniOsobuMirkom stavljam novu osobu:");
            o = new Osoba("Mirko", 2);
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz metode ZamijeniOsobuMirkom:");
        }

        private static void PromijeniIme(Osoba o, string novoIme)
        {
            Console.WriteLine($"U metodi PromijeniIme mijenjam ime u {novoIme}");
            o.Ime = novoIme;
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz metode PromijeniIMe:");
        }

        public static void PromjenaArgumentaReferentnogTipa()
        {
            Osoba janko = new Osoba("Janko", 1);
            Console.WriteLine(janko);

            ZamijeniOsobuMirkom(janko);
            Console.WriteLine(janko);

           

            Console.WriteLine();

            PromijeniIme(janko, "Pero");
            Console.WriteLine(janko);

        }

        static void Main(string[] args)
        {
            PromjenaArgumentaReferentnogTipa();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
