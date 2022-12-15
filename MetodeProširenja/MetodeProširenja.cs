﻿using System;

namespace Vsite.CSharp.Metode
{
    // TODO:120 U klasu MojaProširenja dodati metodu proširenja (extension method) BrojRiječi klasi string koja kao rezultat vraća broj riječi
    public static class MojaProširenja
    {
        public static int BrojRijeci(this string s)
        {
            return s.Split(new char[] {' ', '.',',','?','!',';',':'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class MetodeProširenja
    {
        public static int DajBrojRiječi(string tekst)
        {
            // TODO:121 Zamijeniti povratnu vrijednost rezultatom metode proširenja BrojRiječi. Pokrenuti program i provjeriti ispise.
            return tekst.BrojRijeci();
        }

        // TODO:122 Pokrenuti i provjeriti testove (4 testa u grupi TestMetodeProširenja moraju proći).

        static void Main(string[] args)
        {
            string s = "Kako je počeo rat na mom otoku?";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            s = "Brojim: jedan, dva, tri! Tko se nije skrio...";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));
        }
    }
}
