﻿using System;

namespace Vsite.CSharp.Metode
{
    class ZamjenaObjekata
    {
        static void Zamijeni(ref string s1,ref string s2)
        {
            string temp = s2;
            s2 = s1;
            s1 = temp;
        }
    
        public static void ZamjenaStringova( string prvi, string drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            Zamijeni(ref prvi,ref drugi);

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }
        static void Zamijeni(ref object s1, ref object s2)
        {
            var temp = s2;
            s2 = s1;
            s1 = temp;
        }

        public static void ZamjenaIntova(int prvi, int drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
            object i1 = (object)prvi;
            object i2 = (object)drugi;
            Zamijeni(ref i1,ref i2);
            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

       

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
