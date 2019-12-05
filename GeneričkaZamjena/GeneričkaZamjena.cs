using System;

namespace Vsite.CSharp.Metode
{
    class GeneričkaZamjena
    {
      
        public static void Zamjeni<T>(ref T a,ref T b)
        {
            var c = a;
            a = b;
            b = c;
        }
        private static void IspišiPar(object o1, object o2)
        {
            Console.WriteLine("{0} - {1}", o1.ToString(), o2.ToString());
        }

        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 10;
            IspišiPar(i1, i2);
         
            Zamjeni<int>(ref i1,ref i2);
            IspišiPar(i1, i2);

            Console.WriteLine();

            double d1 = 1.23;
            double d2 = 4.56;
            IspišiPar(d1, d2);
           
            Zamjeni(ref d1,ref d2);
            IspišiPar(d1, d2);

            Console.WriteLine();

            string s1 = "Ivica";
            string s2 = "Marica";
        
            IspišiPar(s1, s2);
           
            Zamjeni(ref s1, ref s2);           
            IspišiPar(s1, s2);

     

            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
