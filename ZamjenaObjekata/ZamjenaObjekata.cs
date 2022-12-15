using System;

namespace Vsite.CSharp.Metode
{
    class ZamjenaObjekata
    {
        // 061 Promijeniti metodu tako da se zamjena odrazi u pozivajućem kodu.
        static void Zamijeni(ref object s1,ref object s2)
        {
            (s1, s2) = (s2, s1);
            //string temp = s2;
            //s2 = s1;
            //s1 = temp;
        }


        public static void ZamjenaStringova(string prvi, string drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            object o1 = prvi;
            object o2 = drugi;
            Zamijeni(ref o1, ref  o2);

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'",(string)o1);
            Console.WriteLine("drugi = '{0}'", (string)o2);
        }

        public static void ZamjenaIntova(int prvi, int drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            // 062 Promijeniti metodu Zamijeni tako da umjesto tipa string prima tip object i tako podržava zamjenu bilo kojeg tipa objekta. Dodati poziv te metode za 2 argumenta tipa int te provjeriti funkcionalnost.
            object o1 = prvi;
            object o2 = drugi;
            Zamijeni(ref o1, ref o2);
            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", o1);
            Console.WriteLine("drugi = '{0}'", o2);
        }

        // 063 Pokrenuti i provjeriti testove (oba testa u grupi TestZamjeneObjekata moraju proći)

        // 060 Pokrenuti program i provjeriti ispis.
        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            ZamjenaStringova(prvi, drugi);
            Console.WriteLine();
            ZamjenaIntova(1, 2);
        }
    }
}
