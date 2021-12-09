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

            // 030 Dodati poziv metode ZamijeniOsobuMirkom s prosljeđenom osobom janko i ispisati osobu nakon poziva te metode.
            ZamijeniOsobuMirkom(janko);
            Console.WriteLine(janko);
            // 031 Pokrenuti program i obrazložiti ispis. // kopiji refenence pridruzili novi objekt. janko je i dalje janko.

            Console.WriteLine();

            // 032 Dodati poziv metode PromijeniIme s prosljeđenom osobom janko i novim imenom "Pero" i ispisati osobu nakon poziva te metode.
            PromijeniIme(janko, "Pero");
            Console.WriteLine(janko);
            // 033 Pokrenuti program i obrazložiti ispis. // janko je posato pero, jer nismo tvorili novi objekt u metodi i pridruzili njemu novo ime

            // 034 Pokrenuti i provjeriti testove (test TestPromjeneArgumentaReferentogTipa treba proći).
        }

        static void Main(string[] args)
        {
            PromjenaArgumentaReferentnogTipa();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
