namespace Vsite.CSharp.Metode.Struktura
{
    public struct Osoba
    {
        public Osoba(string ime, int matičniBroj)
        {
            Ime = ime;
            MatičniBroj = matičniBroj;
        }

        public string Ime;
        public int MatičniBroj;

        public override string ToString()
        {
            return $"Ime: {Ime}, MB: {MatičniBroj}";
        }
    }
}
