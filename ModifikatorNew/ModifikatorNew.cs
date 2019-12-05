using System;

namespace Vsite.CSharp.Metode
{
    class ModifikatorNew
    {
        public class Bazna
        {
            public void PredstaviSe()
            {
                Console.WriteLine("Bazna klasa");
            }
        }

        public class Izvedena : Bazna
        {
            public new void PredstaviSe()
            {
                Console.Write("Izvedena klasa, izvedena iz:");
                base.PredstaviSe();
            }

        }

        static void Main(string[] args)
        {
            Bazna bazna = new Izvedena();
            bazna.PredstaviSe();

            Console.WriteLine();

            Izvedena i = new Izvedena();
            i.PredstaviSe();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
