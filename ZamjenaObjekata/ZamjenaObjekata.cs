using System;

namespace Vsite.CSharp.Metode
{
    class ZamjenaObjekata
    {
        // Pokrenuti program i provjeriti ispis.

        // Promijeniti metodu tako da se zamjena odrazi u pozivajućem kodu.
        static void Zamijeni(ref string s1,ref string s2)
        {
            string temp = s2;
            s2 = s1;
            s1 = temp;
        }

        static void Zamijeni(ref object s1, ref object s2)
        {
            var temp = s2;
            s2 = s1;
            s1 = temp;
        }

        public static void ZamjenaStringova(string prvi, string drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            Zamijeni(ref prvi, ref drugi);

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        public static void ZamjenaIntova(int prvi, int drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            // Preopteretiti metodu Zamijeni tako da umjesto tipa string prima tip object i tako podržava zamjenu bilo kojeg tipa objekta. Dodati poziv te metode za 2 argumenta tipa int te provjeriti funkcionalnost.
            object i1 = (object)prvi;
            object i2 = (object)drugi;
            Zamijeni(ref i1, ref i2);
            prvi = (int)i1;
            drugi = (int)i2;
            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        // Pokrenuti i provjeriti testove (2 testa "ZamjenaObjekata_..." moraju proći)

        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            ZamjenaStringova(prvi, drugi);
            Console.WriteLine();
            ZamjenaIntova(1, 2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
