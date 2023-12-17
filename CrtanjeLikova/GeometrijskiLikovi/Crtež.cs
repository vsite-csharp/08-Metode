namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    // :090 Pokrenuti program i provjeriti funkcioniranje tipki na alatnoj traci (toolbar).
    class Crtež
    {
        public Crtež()
        {
            SložiOgledniCrtež();
        }

        public void DodajLik(GeometrijskiLik lik)
        {
            likovi.Add(lik);
        }

        public void Iscrtaj(Graphics g)
        {
            foreach (GeometrijskiLik lik in likovi)
            { 
                lik.NacrtajOkvir(g,Color.Black);
            }
        }

        public void PomakniLikove(float dx, float dy)
        {
            foreach (GeometrijskiLik lik in likovi)
            {
                lik.Pomakni(dx, dy);
            }
        }

        public void UvećajLikove(float faktor)
        {
            foreach (GeometrijskiLik lik in likovi)
            { 
                lik.Uvećaj(faktor);
            }
        }

        private void SložiOgledniCrtež()
        {
            DodajLik(new Pravokutnik(10, 10, 40, 30,Color.Red,Color.Blue));
            DodajLik(new Pravokutnik(80, 120, 150, 40,Color.Yellow,Color.Green));
            DodajLik(new Pravokutnik(150, 100, 50, 150, Color.Orange, Color.Purple));

            // :091 U projekt dodati novu klasu Elipsa, izvedenu iz klase GeometrijskiLik te implemenirati potrebne metode.

            // :092 Otkomentirati donje naredbe i pokrenuti program.
            DodajLik(new Elipsa(80, 60, 60, 40, Color.Cyan, Color.DarkBlue));
            DodajLik(new Elipsa(180, 80, 50, 80, Color.Magenta, Color.Black));

            // :097 Dodati u gornjim konstruktorima boju popune i boju okvira za svaki lik te pokrenuti program.
        }

        private readonly List<GeometrijskiLik> likovi = new List<GeometrijskiLik>();
    }
}
