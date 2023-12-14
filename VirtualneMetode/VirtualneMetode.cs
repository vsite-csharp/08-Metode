﻿using System.Text;

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

    // TODO:082 U klase Izvedena1 i Izvedena2 dodajte javno dostupne metode IspišiImeObično koje će ispisati "Izvedena1 Obično", odnosno "Izvedena2 Obično". Pokrenite program i usporedite ispise s prijašnjima.
    // TODO:083 U klase Izvedena1 i Izvedena2 dodajte javno dostupne metode IspišiImeVirtualno koje će ispisati "Izvedena1 Virtualno", odnosno "Izvedena2 Virtualno". Pokrenite program i usporedite ispise s prijašnjima.
    class Izvedena1 : Bazna
    {
        public new void IspišiImeObično() // upozerenje  
        {
            Console.WriteLine("Izvedena 1 Obično");
        }

        public new virtual void IspišiImeVirtualno()
        {
            Console.WriteLine("Izvedena 1 Virtualno");
        }

    }

    class Izvedena2 : Izvedena1
    {
        public new void IspišiImeObično()
        {
            Console.WriteLine("Izvedena 2 Obično");
        }

        public new virtual void IspišiImeVirtualno()
        {
            Console.WriteLine("Izvedena 2 Virtualno");
        }
    }

    static class VirtualneMetode
    {
        public static void PoziviNevirtualnihMetoda()
        {
            Console.WriteLine("\n* Bazna b = new Bazna(); b.IspišiImeObično();");
            Bazna bazna = new Bazna();
            bazna.IspišiImeObično();

            Console.WriteLine("\n* Izvedena1 i1 = new Izvedena1(); i1.IspišiImeObično();");
            Izvedena1 izvedena1 = new Izvedena1();
            izvedena1.IspišiImeObično();

            Console.WriteLine("\n* Izvedena2 i2 = new Izvedena2(); i2.IspišiImeObično();");
            Izvedena2 izvedena2 = new Izvedena2();
            izvedena2.IspišiImeObično();

            Console.WriteLine("\n* Bazna b = new Izvedena1(); b.IspišiImeObično();");
            bazna = new Izvedena1();
            bazna.IspišiImeObično();

            Console.WriteLine("\n* Bazna b = new Izvedena2(); b.IspišiImeObično();");
            bazna = new Izvedena2();
            bazna.IspišiImeObično();
        }

        public static void PoziviVirtualnihMetoda()
        {
            Console.WriteLine("\n* Bazna b = new Bazna(); b.IspišiImeVirtualno();");
            Bazna bazna = new Bazna();
            bazna.IspišiImeVirtualno();

            Console.WriteLine("\n* Izvedena1 i1 = new Izvedena1(); i1.IspišiImeVirtualno();");
            Izvedena1 izvedena1 = new Izvedena1();
            izvedena1.IspišiImeVirtualno();

            Console.WriteLine("\n* Izvedena2 i2 = new Izvedena2(); i2.IspišiImeVirtualno();");
            Izvedena2 izvedena2 = new Izvedena2();
            izvedena2.IspišiImeVirtualno();

            Console.WriteLine("\n* Bazna b = new Izvedena1(); b.IspišiImeVirtualno();");
            bazna = new Izvedena1();
            bazna.IspišiImeVirtualno();

            Console.WriteLine("\n* Bazna b = new Izvedena2(); b.IspišiImeVirtualno();");
            bazna = new Izvedena2();
            bazna.IspišiImeVirtualno();
        }

        static void Main()
        {
            // Pogledajte metode PoziviNevirtualnihMetoda i PoziviVirtualnihMetoda i zaključite što će se ispisati prilikom njihova poziva.
            // Pokrenite program i provjerite što će se ispisati.

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("*** Pozivi nevirtualnih metoda ***");
            PoziviNevirtualnihMetoda();

            Console.WriteLine("\n*** Pozivi virtualnih metoda ***");
            PoziviVirtualnihMetoda();
        }
    }
}
