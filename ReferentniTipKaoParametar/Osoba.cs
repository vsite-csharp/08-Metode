namespace Vsite.CSharp.Metode.Klasa
{
    public class Osoba
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
