using System;
using System.Text.RegularExpressions;

namespace Vsite.CSharp.Metode
{
    //  U klasu MojaProširenja dodati metodu proširenja (extension method) BrojRiječi klasi string koja kao rezultat vraća broj riječi
    public static class MojaProširenja
    {
        //  Zamijeniti povratnu vrijednost rezultatom metode proširenja BrojRiječi. Pokrenuti program i provjeriti ispise.
        public static int BrojRiječi(this string express)
        {
            var replExpress = Regex.Replace(express, @"[.:;!.,]", " ").Trim();
            return Regex.Split(replExpress, @"\s+").Length;
        }
    }


    //  Pokrenuti i provjeriti testove (4 testa u grupi TestMetodeProširenja moraju proći).
    class MetodeProširenja
    {
        public static int DajBrojRiječi(string tekst)
        {
            // Zamijeniti povratnu vrijednost rezultatom metode proširenja BrojRiječi. Pokrenuti program i provjeriti ispise.
            return tekst.BrojRiječi();
        }

        // Pokrenuti i provjeriti testove (4 testa u grupi TestMetodeProširenja moraju proći).
        static void Main(string[] args)
        {
            string s = "Ovo je neki tekst koji nema veze sa vezom";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            s = "Ovaj tekst ce prebrojati sve rijeci";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}