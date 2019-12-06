using System.Collections.Generic;
using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    // TODO:090 Pokrenuti program i provjeriti funkcioiranje tipki.
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
            DodajLik(new Pravokutnik(10, 10, 40, 30,Color.AliceBlue,Color.Bisque));
            DodajLik(new Pravokutnik(80, 120, 150, 40,Color.Tan,Color.Firebrick));
            DodajLik(new Pravokutnik(150, 100, 50, 150,Color.Teal,Color.SaddleBrown));

        
            DodajLik(new Elipsa(80, 60, 60, 40,Color.RoyalBlue,Color.Navy));
            DodajLik(new Elipsa(180, 80, 50, 80,Color.Gainsboro,Color.DodgerBlue));

        }

        private List<GeometrijskiLik> likovi = new List<GeometrijskiLik>();
    }
}
