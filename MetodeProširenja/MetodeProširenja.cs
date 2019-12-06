using System;

namespace Vsite.CSharp.Metode
{
    static class MojeMetodeProširenja
    {
        public static int BrojRijeci(this string s)
        {
           return s.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }


    class MetodeProširenja
    {
        public static int DajBrojRiječi(string tekst)
        {
            return tekst.BrojRijeci();
        }

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
