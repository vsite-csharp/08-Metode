using System;

namespace Vsite.CSharp.Metode
{
    class PreopterećenjePodrazumijevaniArg
    {
        // :010 Razmotriti što će se pokretanjem programa ispisati. Pokrenuti program i provjeriti ispise.
        public static int Zbroji(int x = 1, int y = 2, int z = 3)
        {
            return x + y + z;
        }

        // :011 Preopteretiti funkciju Zbroji novom funkcijom public static int Zbroji(int x, int y) koja će vratiti zbroj argumenata. 
        public static int Zbroji(int x, int y )
        {
            return x + y; 
        }
        // Nakon stvaranja ove metode u drugom slučaju se poziva ova metoda
        // Mogu se definirati sa argumentiam od kraja metode

        // :012 Razmotriti koje će se inačice metoda pozvati. Ponovno pokrenuti programa te usporediti ispise.

        // :013 Provjeriti što bi se dogodilo ako bismo drugoj metodi definirali y s podrazumijevanim argumentom.
        // Treći slučaj se ne može izvršiti 

        // :014 Pokrenuti i provjeriti testove (3 testa "TestPreopterećenjePodrazumijevaniArg" moraju proći).


        static void Main(string[] args)
        {
            Console.WriteLine(Zbroji(5, 6, 7)); //18
            Console.WriteLine(Zbroji(5, 5)); //13
            Console.WriteLine(Zbroji(3)); // 8

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
