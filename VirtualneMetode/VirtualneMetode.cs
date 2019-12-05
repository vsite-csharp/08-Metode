using System;

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


    class Izvedena1 : Bazna
    {
        public new void IspišiImeObicno()
        {
            Console.WriteLine("Izvedena1 Obično");
        }
        public override void IspišiImeVirtualno()
        {
            Console.WriteLine("Izvedena1 Virtualno");
        }
    }

    class Izvedena2 : Bazna
    {
        public new void IspišiImeObicno()
        {
            Console.WriteLine("Izvedena2 Obično");
        }
        public override void IspišiImeVirtualno()
        {
            Console.WriteLine("Izvedena2 Virtualno");
        }

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
