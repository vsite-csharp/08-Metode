﻿using System;

namespace Vsite.CSharp.Metode
{
    class Bazna
    {
        public void IspišiImeObično()
        {
            Console.WriteLine("Bazna Obično");
        }

        public virtual void IspišiImeVirtualno()
        {
            Console.WriteLine("Bazna Virtualno");
        }
    }

    // TODO:081 U klase Izvedena1 i Izvedena2 dodajte javno dostupne metode IspišiImeObično koje će ispisati "Izvedena1 Obično", odnosno "Izvedena2 Obično". Pokrenite program i usporedite ispise s prijašnjima.

    // TODO:082 U klase Izvedena1 i Izvedena2 dodajte javno dostupne metode IspišiImeVirtualno koje će ispisati "Izvedena1 Virtualno", odnosno "Izvedena2 Virtualno". Pokrenite program i usporedite ispise s prijašnjima.
    class Izvedena1 : Bazna
    {

    }

    class Izvedena2 : Bazna
    {

    }

    class VirtualneMetode
    {
        public static void ZasebniPoziviNevirtualnihMetoda()
        {
            Bazna bazna = new Bazna();
            bazna.IspišiImeObično();

            Izvedena1 izvedena1 = new Izvedena1();
            izvedena1.IspišiImeObično();

            Izvedena2 izvedena2 = new Izvedena2();
            izvedena2.IspišiImeObično();
        }

        public static void PoziviNevirtualnihMetodaNaKolekcijiBaznogTipa()
        {
            Bazna[] objekti = new Bazna[] { new Bazna(), new Izvedena1(), new Izvedena2() };
            foreach (Bazna o in objekti)
                o.IspišiImeObično();
        }

        public static void ZasebniPoziviVirtualnihMetoda()
        {
            Bazna bazna = new Bazna();
            bazna.IspišiImeVirtualno();

            Izvedena1 izvedena1 = new Izvedena1();
            izvedena1.IspišiImeVirtualno();

            Izvedena2 izvedena2 = new Izvedena2();
            izvedena2.IspišiImeVirtualno();
        }

        public static void PoziviVirtualnihMetodaNaKolekcijiBaznogTipa()
        {
            Bazna[] objekti = new Bazna[] { new Bazna(), new Izvedena1(), new Izvedena2() };
            foreach (Bazna o in objekti)
                o.IspišiImeVirtualno();
        }


        static void Main(string[] args)
        {
            // TODO:080 Pokrenite program i provjerite što će se ispisati.

            Console.WriteLine("Zasebni pozivi nevirtualnih metoda:");
            ZasebniPoziviNevirtualnihMetoda();

            Console.WriteLine("Pozivi nevirtualnih metoda na kolekciji baznih objekata:");
            PoziviNevirtualnihMetodaNaKolekcijiBaznogTipa();

            Console.WriteLine("Zasebni pozivi virtualnih metoda:");
            ZasebniPoziviVirtualnihMetoda();

            Console.WriteLine("Pozivi virtualnih metoda na kolekciji baznih objekata:");
            PoziviVirtualnihMetodaNaKolekcijiBaznogTipa();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
