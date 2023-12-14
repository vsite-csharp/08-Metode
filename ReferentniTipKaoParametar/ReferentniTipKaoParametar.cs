﻿namespace Vsite.CSharp.Metode
{
    using Osoba = Klasa.Osoba;

    static class ReferentniTipKaoParametar
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
            Osoba osoba = new Osoba("Janko", 1);
            Console.WriteLine(osoba);

            // Dodati poziv metode ZamijeniOsobuMirkom s proslijeđenom osobom i ispisati osobu nakon poziva te metode.

            ZamijeniOsobuMirkom(osoba);
            Console.WriteLine(osoba);

            // Pokrenuti program i obrazložiti ispis.

            Console.WriteLine();

            // Dodati poziv metode PromijeniIme s proslijeđenom osobom i novim imenom "Pero" i ispisati osobu nakon poziva te metode.

            PromijeniIme(osoba, "Pero");
            Console.WriteLine(osoba);

            // Pokrenuti program i obrazložiti ispis.

            // Pokrenuti i provjeriti testove (test TestPromjeneArgumentaReferentogTipa treba proći).
        }

        static void Main()
        {
            PromjenaArgumentaReferentnogTipa();
        }
    }
}
