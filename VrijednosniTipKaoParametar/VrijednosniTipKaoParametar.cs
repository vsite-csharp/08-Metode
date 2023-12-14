namespace Vsite.CSharp.Metode
{
    using Osoba = Struktura.Osoba;

    static class VrijednosniTipKaoParametar
    {
        static void Uvećaj(int n)
        {
            n += 1;
            Console.WriteLine($"U metodi Uvećaj: {n}");
        }

        private static void UvećavanjeVrijednosnogParametra()
        {
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
            Osoba osoba = new Osoba("Janko", 1);
            Console.WriteLine(osoba);

            ZamijeniOsobuDarkom(osoba);
            Console.WriteLine(osoba);
            // :021 Dodati poziv metode ZamijeniOsobuDarkom s proslijeđenom osobom i ispisati osobu nakon poziva te metode.

            // :022 Pokrenuti program i obrazložiti ispis.
            // referentni tipovi nakon pokretanja metoda ne mijenjaju vrijednosti svojih polja nakon izlaska iz metode

            Console.WriteLine();

            PromijeniIme(osoba, "Pero");
            Console.WriteLine(osoba);
            // :023 Dodati poziv metode PromijeniIme s proslijeđenom osobom i novim imenom "Pero" i ispisati osobu nakon poziva te metode.

            //referentni tipovi nakon pokretanja metoda ne mijenjaju vrijednosti svojih polja nakon izlaska iz metode
            // :024 Pokrenuti program i obrazložiti ispis.

            // :025 Pokrenuti i provjeriti testove (test TestPromjeneArgumentaVrijednosnogTipa treba proći)
        }

        // :020 Pokrenuti program, provjeriti ispise te ih obrazložiti.
        static void Main()
        {
            UvećavanjeVrijednosnogParametra();
            Console.WriteLine();
            PromjenaArgumentaVrijednosnogTipa();
        }
    }
}