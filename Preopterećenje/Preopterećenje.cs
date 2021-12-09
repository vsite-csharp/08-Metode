using System;

namespace Vsite.CSharp.Metode
{
    class Preopterećenje
    {
        // :000 Pokrenuti program i provjeriti ispis.
        // preopterećenje u smislu imena metode, ako joj dali više nego dopušteno
        public static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(double {broj1}, double {broj2})");
        }

        // :001 Napisati statičku javno dostupnu preopterećenu verziju metode MojaMetoda koja prima dva argumenta: prvi tipa int, a drugi tipa double. Metoda mora ispisati $"MojaMetoda(int {broj1}, double {broj2})"

        public static void MojaMetoda(int broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(int {broj1}, double {broj2})");
            //sada se 2 metode razlikuju po potpisu, double/integer prvi argument
            // zove se metoda koja traži manje implicitnih pretvorbi
        }

        // :002 Razmotriti koje će se inačice pozivati. Pokrenuti program i usporediti ispis s prijašnjim.

        // :003 Pokrenuti i provjeriti testove (4 testa "TestPreopterećenjaMetode" moraju proći).


        static void Main(string[] args)
        {
           // metoda očekuje 2 double argumentima, a mi proslijeđujemo integer
           // pokuša implicitnoo pretvoriti int u double
           // jer ne postoji opasnost da se izgubi informacija, broj integer u očekivani double metode
            int i1 = 1;
            int i2 = 2;
            double d1 = 3;
            double d2 = 4;
            // decimal d2 = 4;
            // decimal se ne može implicitno pretvoriti u double

            MojaMetoda(i1, i2);
            MojaMetoda(i1, d1);
            MojaMetoda(d1, d2);
            MojaMetoda(d1, i2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
