using System.Collections.Generic;
using System.Drawing;


//BITNO OVERRIDE-ati OnPaint metodu za graficko crtanje!!!!!

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
            DodajLik(new Pravokutnik(10, 10, 40, 30,Brushes.Blue,Pens.Black));
            DodajLik(new Pravokutnik(80, 120, 150, 40, Brushes.Crimson, Pens.Black));
            DodajLik(new Pravokutnik(150, 100, 50, 150, Brushes.Blue, Pens.Crimson));

            DodajLik(new Elipsa(80, 60, 60, 40, Brushes.Black, Pens.Gray));
            DodajLik(new Elipsa(180, 80, 50, 80, Brushes.Yellow, Pens.Orange));
        }

        private List<GeometrijskiLik> likovi = new List<GeometrijskiLik>();
    }
}
