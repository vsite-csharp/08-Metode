﻿namespace Vsite.CSharp.Metode
{
    static class PreopterećenjePodrazumijevaniArg
    {
        // TODO:010 Razmotriti što će se pokretanjem programa ispisati. Pokrenuti program i provjeriti ispise.
        public static int Zbroji(int x, int y = 2, int z = 3)
        {
            return x + y + z;
        }

        // :011 Preopteretiti funkciju Zbroji novom funkcijom public static int Zbroji(int x, int y) koja će vratiti zbroj argumenata. 
        public static int Zbroji(int x, int y)
        {
            return x + y;
        }

        // :012 Razmotriti koje će se inačice metoda pozvati. Ponovno pokrenuti programa te usporediti ispise.

        // :013 Provjeriti što bi se dogodilo ako bismo drugoj metodi definirali y s podrazumijevanim argumentom.

        // :014 Pokrenuti i provjeriti testove (3 testa "TestPreopterećenjePodrazumijevaniArg" moraju proći).


        static void Main()
        {
            Console.WriteLine(Zbroji(5, 6, 7));
            Console.WriteLine(Zbroji(5, 5));
            Console.WriteLine(Zbroji(3));
        }
    }
}
