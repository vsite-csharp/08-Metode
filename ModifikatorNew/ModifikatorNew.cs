﻿namespace Vsite.CSharp.Metode
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

        }

        // TODO:101 Izvesti program i usporediti donje ispise.
        // TODO:102 Pokrenuti i provjeriti testove (3 testa u grupi TestModifikatoraNew moraju proći)
        static void Main()
        {
            Bazna bazna = new Izvedena();
            bazna.PredstaviSe();

            Console.WriteLine();

            Izvedena i = new Izvedena();
            i.PredstaviSe();
        }
    }
}
