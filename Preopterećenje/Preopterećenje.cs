using System;

namespace Vsite.CSharp.Metode
{
    class Preopterećenje
    {
       
        /*MojaMetoda(double 1, double 2)
        MojaMetoda(double 1, double 3)
        MojaMetoda(double 3, double 4)
        MojaMetoda(double 3, double 2)
        GOTOVO!!!*/
        public static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(double {broj1}, double {broj2})");
        }

        
        public static void MojaMetoda(int broj1, double broj2)
        {
            Console.WriteLine($"MojaMetoda(int {broj1}, double {broj2})");
                    /*MojaMetoda(int 1, double 2)
                    MojaMetoda(int 1, double 3)
                    MojaMetoda(double 3, double 4)
                    MojaMetoda(double 3, double 2)
                         GOTOVO!!!...bira metodu kooja odgovara po parametrima
             */
        }

      


        static void Main(string[] args)
        {
            int i1 = 1;
            int i2 = 2;
            double d1 = 3;
            double d2 = 4;

            MojaMetoda(i1, i2);
            MojaMetoda(i1, d1);
            MojaMetoda(d1, d2);
            MojaMetoda(d1, i2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
