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
            // TODO:100 Dodati javno dostupnu metodu void PredstaviSe() koja će ispisati "Izvedena klasa, izvedena iz:" te će pozvati PredstaviSe iz klase Bazna.
            public new void PredstaviSe()
            {
                Console.WriteLine("Izvedena klasa, izvedena iz:"); base.PredstaviSe();
            }
        }

        static void Main(string[] args)
        {
            // TODO:101 Izvesti program i usporediti donje ispise.

            // TODO:102 Pokrenuti i provjeriti testove (3 testa "ModifikatorNew_..." moraju proći)
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
