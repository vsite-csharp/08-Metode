using System;

namespace Vsite.CSharp.Metode
{
    using Osoba = Struktura.Osoba;

    class VrijednosniTipKaoParametar
    {
        static void Uvećaj(int n)
        {
            n += 1;
            Console.WriteLine($"U metodi Uvećaj: {n}");
        }

        private static void UvećavanjeVrijednosnogParametra()
        {
            // Pokrenuti program, provjeriti ispise te ih obrazložiti.
            int n = 5;
            Console.WriteLine($"Prije metode Uvećaj: {n}");
            Uvećaj(n);
            Console.WriteLine($"Nakon metode Uvećaj: {n}");
        }

        private static void ZamijeniOsobuDarkom(Osoba o)
        {
            Console.WriteLine("U metodi ZamijeniOsobuDarkom stavljam novu osobu:");
            o = new Osoba("Darko", 2);
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz metode ZamijeniOsobuDarkom:");
        }

        private static void PromijeniIme(Osoba o, string novoIme)
        {
            Console.WriteLine($"U metodi PromijeniIme mijenjam ime u {novoIme}");
            o.Ime = novoIme;
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz metode PromijeniIMe:");
        }

        public static void PromjenaArgumentaVrijednosnogTipa()
        {
            Osoba janko = new Osoba("Janko", 1);
            Console.WriteLine(janko);

            // Dodati poziv metode ZamijeniOsobuDarkom s prosljeđenom osobom janko i ispisati osobu nakon poziva te metode.
            ZamijeniOsobuDarkom(janko);
            Console.WriteLine(janko);

            // Pokrenuti program i obrazložiti ispis.

            Console.WriteLine();

            // TODO:023 Dodati poziv metode PromijeniIme s prosljeđenom osobom janko i novim imenom "Pero" i ispisati osobu nakon poziva te metode.
            PromijeniIme(janko, "Pero");
            Console.WriteLine(janko);

            // Pokrenuti program i obrazložiti ispis.

            // Pokrenuti i provjeriti testove (test VrijednosniTipKaoArgument_NakonIzlaskaIzMetodeObjektJeNepromijenjen treba proći)
        }

        static void Main(string[] args)
        {
            UvećavanjeVrijednosnogParametra();
            Console.WriteLine();
            PromjenaArgumentaVrijednosnogTipa();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}