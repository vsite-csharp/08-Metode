using System.Collections.Generic;
using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    // Pokrenuti program i provjeriti funkcioniranje tipki na alatnoj traci (toolbar).
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
                lik.Nacrtaj(g);
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

        private Color RandomColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void SložiOgledniCrtež()
        {
            DodajLik(new Pravokutnik(10, 10, 40, 30, RandomColor(), RandomColor()));
            DodajLik(new Pravokutnik(80, 120, 150, 40, RandomColor(), RandomColor()));
            DodajLik(new Pravokutnik(150, 100, 50, 150, RandomColor(), RandomColor()));
            DodajLik(new Elipsa(40, 40, 60, 120, RandomColor(), RandomColor()));

            //  U projekt dodati novu klasu Elipsa, izvedenu iz klase GeometrijskiLik te implemenirati potrebne metode.

            // Otkomentirati donje naredbe i pokrenuti program.
            DodajLik(new Elipsa(80, 60, 60, 40, RandomColor(), RandomColor()));
            DodajLik(new Elipsa(180, 80, 50, 80, RandomColor(), RandomColor()));

            // Dodati u gornjim konstruktorima boju popune i boju okvira za svaki lik te pokrenuti program.
        }

        private List<GeometrijskiLik> likovi = new List<GeometrijskiLik>();
    }
}
