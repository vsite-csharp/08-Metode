using System;

namespace Vsite.CSharp.Metode
{
    class PreopterećenjePodrazumijevaniArg
    {
      
        /*
                18
                13
                8
                GOTOVO!!!
             */
        public static int Zbroji(int x = 1, int y = 2, int z = 3)
        {
            return x + y + z;
        }

       
        public static int Zbroji(int x, int y)
        {
            return x + y;
            /* 18
                10
                8
                GOTOVO!!!
                */
        }

       


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
