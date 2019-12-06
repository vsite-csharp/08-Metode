using System;

namespace Vsite.CSharp.Metode
{

    class Params
    {
        public static double Zbroji(params double[] pribrojnici)
        {
            double sum = 0;
            for(int i=0; i<pribrojnici.Length; ++i)
            {
                sum += pribrojnici[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            double zbroj = Zbroji(1, 2, 3, 4);
            Console.WriteLine(zbroj);

            Console.WriteLine(Zbroji(3.2, 4.3, 7.5));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

    }
}
