using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode
{
    class Program
    {
        //:140 Pogledati kod i potpise metoda Main i IzračunajZbrojAsinkrono te pozive metode IzračunajZbrojAsinkrono. 
        //:141 Pokrenuti program i usporediti trajanja i rezultate. 
        //:142 Pokrenuti program bez debuggiranja (Ctrl+F5) i usporediti trajanja s prethodnima.
        static async Task Main(string[] args)
        {
            const int broj = 10000000;

            // Pokrećemo sve metode prije mjerenja da bi JIT preveo kod u strojni
            Stopwatch štoperica = new Stopwatch();
            štoperica.Start();
            štoperica.Stop();

            IzračunajZbroj(1, 2);

            Task<long> zbrajanje = IzračunajZbrojAsinkrono(1, 2);
            await zbrajanje;

            // Ovdje počinje mjerenje poziva metoda
            štoperica.Restart();

            long zbroj = IzračunajZbroj(0, broj);
            zbroj += IzračunajZbroj(broj, 2 * broj);
            zbroj += IzračunajZbroj(2 * broj, 3 * broj);

            štoperica.Stop();
            Console.WriteLine($"Trajanje sinkronog izračunavanja: {štoperica.ElapsedTicks}");
            Console.WriteLine($"Zbroj: {zbroj}");

            štoperica.Restart();

            Task<long> zbrajanje1 = IzračunajZbrojAsinkrono(0, broj);
            Task<long> zbrajanje2 = IzračunajZbrojAsinkrono(broj, 2 * broj);
            Task<long> zbrajanje3 = IzračunajZbrojAsinkrono(2 * broj, 3 * broj);

            zbroj = await zbrajanje1;
            zbroj += await zbrajanje2;
            zbroj += await zbrajanje3;

            štoperica.Stop();
            Console.WriteLine($"Trajanje asinkronog izračunavanja: {štoperica.ElapsedTicks}");
            Console.WriteLine($"Zbroj: {zbroj}");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static long IzračunajZbroj(int prvi, int zadnji)
        {
            Debug.Assert(prvi <= zadnji);
                
            long zbroj = 0;
            for (int i = prvi; i < zadnji; ++i)
                zbroj += i;
            return zbroj;
        }

        async static Task<long> IzračunajZbrojAsinkrono(int prvi, int zadnji)
        {
            Debug.Assert(prvi <= zadnji);

            return await Task.Factory.StartNew(() =>
            {
                long zbroj = 0;
                for (int i = prvi; i < zadnji; ++i)
                    zbroj += i;
                return zbroj;
            });
        }
    }
}
