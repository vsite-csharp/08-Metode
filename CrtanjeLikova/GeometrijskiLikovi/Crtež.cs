using System.Collections.Generic;
using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
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
                lik.Nacrtaj(g);
        }

        public void PomakniLikove(float dx, float dy)
        {
            foreach (GeometrijskiLik lik in likovi)
                lik.Pomakni(dx, dy);
        }

        public void UvećajLikove(float faktor)
        {
            foreach (GeometrijskiLik lik in likovi)
                lik.Uvećaj(faktor);
        }

        private void SložiOgledniCrtež()
        {
            DodajLik(new Pravokutnik(10, 10, 40, 30, Pens.Black, Brushes.Blue));
            DodajLik(new Pravokutnik(80, 120, 150, 40, Pens.Black, Brushes.Red));
            DodajLik(new Pravokutnik(150, 100, 50, 150, Pens.Black, Brushes.Green));

            DodajLik(new Elipsa(80, 60, 60, 40, Pens.Black, Brushes.DarkBlue));
            DodajLik(new Elipsa(180, 80, 50, 80, Pens.Black, Brushes.DarkGreen));
        }

        private List<GeometrijskiLik> likovi = new List<GeometrijskiLik>();
    }
}
