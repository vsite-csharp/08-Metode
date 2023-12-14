namespace Vsite.CSharp.Metode
{
    static class PreopterećenjePodrazumijevaniArg
    {
        // :010 Razmotriti što će se pokretanjem programa ispisati. Pokrenuti program i provjeriti ispise.
        // dodaju se defaultne vrijendosti ako nije za istu varijablu proslijeđena
        public static int Zbroji(int x, int y = 2, int z = 3)
        {
            return x + y + z;
        }

        public static int Zbroji(int x, int y)
        {
            return x + y;
        }
        // :011 Preopteretiti funkciju Zbroji novom funkcijom public static int Zbroji(int x, int y) koja će vratiti zbroj argumenata. 

        // :012 Razmotriti koje će se inačice metoda pozvati. Ponovno pokrenuti programa te usporediti ispise.

        // :013 Provjeriti što bi se dogodilo ako bismo drugoj metodi definirali y s podrazumijevanim argumentom.
        // greška jer se za jedan predani argument ne zna koja će se metoda pozvati, nedovoljno je definirano da se jednoznačno odredi metoda koja će se koristiti.
        // :014 Pokrenuti i provjeriti testove (3 testa "TestPreopterećenjePodrazumijevaniArg" moraju proći).


        static void Main()
        {
            Console.WriteLine(Zbroji(5, 6, 7)); //Zbroji(int x, int y, int z);
            Console.WriteLine(Zbroji(5, 5)); //Zbroji(int x, int y);
            Console.WriteLine(Zbroji(3));
        }
    }
}
