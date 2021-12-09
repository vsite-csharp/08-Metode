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
        // kod zadavanja defaultnih vrijednosti, kod preoptrećenja metode možemo dobiti neočekivane rezultate

        // :011 Preopteretiti funkciju Zbroji novom funkcijom public static int Zbroji(int x, int y) koja će vratiti zbroj argumenata. 

        public static int Zbroji(int x , int y)
        {
            return x + y;
        }
        // u prvom slučaju 1. Zbroji metoda
        // u drugom slučaju 2. jer postoji potpuno slaganje broj argumenata - metoda
        // u trećem 1. metoda
        //public static int Zbroji(int x = 5, int y) // izbjegavati ovo i izbjegavati int y = 8
        //{
        //    return x + y;
        //}

        // :012 Razmotriti koje će se inačice metoda pozvati. Ponovno pokrenuti programa te usporediti ispise.

        // :013 Provjeriti što bi se dogodilo ako bismo drugoj metodi definirali y s podrazumijevanim argumentom.

        // :014 Pokrenuti i provjeriti testove (3 testa "TestPreopterećenjePodrazumijevaniArg" moraju proći).


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
