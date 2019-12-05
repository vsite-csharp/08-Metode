﻿using System;

namespace Vsite.CSharp.Metode
{
    class PreopterećenjePodrazumijevaniArg
    {
        // Pokrenuti program i provjeriti ispise. //18, 13, 8
        public static int Zbroji(int x = 1, int y = 2, int z = 3)
        {
            return x + y + z;
        }

        // Preopteretiti funkciju Zbroji novom funkcijom public static int Zbroji(int x, int y) koja će vratiti zbroj argumenata. 
        public static int Zbroji(int x, int y)
        {
            return x + y;
        }

        // Ponovno pokrenuti programa te usporediti ispise.

        // Provjeriti što bi se dogodilo ako bismo drugoj metodi definirali y s podrazumijevanim argumentom.

        // Pokrenuti i provjeriti testove (3 testa "PreopterećenjePodrazumijevaniArg_..." moraju proći).


        static void Main(string[] args)
        {
            Console.WriteLine(Zbroji(5, 6, 7));
            Console.WriteLine(Zbroji(5, 5));
            Console.WriteLine(Zbroji(3));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
