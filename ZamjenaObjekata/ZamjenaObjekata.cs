﻿using System;

namespace Vsite.CSharp.Metode
{
    class ZamjenaObjekata
    {
        // :061 Promijeniti metodu tako da se zamjena odrazi u pozivajućem kodu.
        //static void Zamijeni(ref string s1, ref string s2)
        //{
        //    string temp = s2;
        //    s2 = s1;
        //    s1 = temp;
        //}        

        //062
        static void Zamijeni(ref object s1, ref object s2)
        {
            object temp = s2;
            s2 = s1;
            s1 = temp;
        }

        public static void ZamjenaStringova(string prvi, string drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            object o1 = prvi;
            object o2 = drugi;
            Zamijeni(ref o1, ref o2);
            prvi = (string)o1;
            drugi = (string)o2;

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        public static void ZamjenaIntova(int prvi, int drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            // :062 Preopteretiti metodu Zamijeni tako da umjesto tipa string prima tip object i tako podržava zamjenu bilo kojeg tipa objekta. Dodati poziv te metode za 2 argumenta tipa int te provjeriti funkcionalnost.
            object o1 = prvi;
            object o2 = drugi;
            Zamijeni(ref o1, ref o2);
            prvi = (int)o1;
            drugi = (int)o2;

            //Zamijeni(ref prvi, ref drugi);

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        // :063 Pokrenuti i provjeriti testove (oba testa u grupi TestZamjeneObjekata moraju proći)

        // :060 Pokrenuti program i provjeriti ispis.
        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            ZamjenaStringova(prvi, drugi);
            Console.WriteLine();
            ZamjenaIntova(1, 2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
