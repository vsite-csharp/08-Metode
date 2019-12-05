using System;

namespace Vsite.CSharp.Metode
{
    // TODO:120 Dodati metodu proširenja (extension method) BrojRiječi klasi string koja kao rezultat vraća broj riječi
    static class MojeMetodeProširenja
    {
        public static int BrojRiječi(this string s)
        {
            return s.Split(new char[] { ' ', '.', '.',  '?', '!', },StringSplitOptions.RemoveEmptyEntries).Length;
            //return 0;
        }
    }


    class MetodeProširenja
    {
        public static int DajBrojRiječi(string tekst)
        {
            // TODO:121 Zamijeniti povratnu vrijednost rezultatom metode proširenja BrojRiječi. Pokrenuti program i provjeriti ispise.

            return tekst.BrojRiječi();
                    /*U 'Kako je poceo rat na mom otoku?' ima 7 rijeci.
        U 'Brojim: jedan, dva, tri! Tko se nije skrio...' ima 8 rijeci.
        GOTOVO!!!*/
                    //return 0;
        }

        // TODO:122 Pokrenuti i provjeriti testove (4 testa "MetodaProširenja_..." moraju proći).

        static void Main(string[] args)
        {
            string s = "Kako je počeo rat na mom otoku?";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            s = "Brojim: jedan, dva, tri! Tko se nije skrio...";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
