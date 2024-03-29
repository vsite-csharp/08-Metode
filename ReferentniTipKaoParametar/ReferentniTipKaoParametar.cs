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

            // TODO:030 Dodati poziv metode ZamijeniOsobuMirkom s proslijeđenom osobom i ispisati osobu nakon poziva te metode.

            // TODO:031 Pokrenuti program i obrazložiti ispis.

            Console.WriteLine();

            // TODO:032 Dodati poziv metode PromijeniIme s proslijeđenom osobom i novim imenom "Pero" i ispisati osobu nakon poziva te metode.

            // TODO:033 Pokrenuti program i obrazložiti ispis.

            // TODO:034 Pokrenuti i provjeriti testove (test TestPromjeneArgumentaReferentogTipa treba proći).
        }

        static void Main()
        {
            PromjenaArgumentaReferentnogTipa();
        }
    }
}
