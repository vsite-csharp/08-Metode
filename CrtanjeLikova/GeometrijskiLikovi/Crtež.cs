﻿using System.Collections.Generic;
using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    // Pokrenuti program i provjeriti funkcioiranje tipki.
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
            DodajLik(new Pravokutnik(10, 10, 40, 30, Brushes.Red, Pens.Black));
            DodajLik(new Pravokutnik(80, 120, 150, 40, Brushes.Yellow, Pens.Black));
            DodajLik(new Pravokutnik(150, 100, 50, 150, Brushes.Green, Pens.Black));

            // U projekt dodati novu klasu Elipsa, izvedenu iz klase GeometrijskiLik te implemenirati potrebne metode.
            // Otkomentirati donje naredbe i pokrenuti program.
            DodajLik(new Elipsa(80, 60, 60, 40, Brushes.Red, Pens.Black));
            DodajLik(new Elipsa(180, 80, 50, 80, Brushes.Yellow, Pens.Black));

            // Dodati u gornjim konstruktorima boju popune i boju okvira za svaki lik te pokrenuti program.
        }

        private List<GeometrijskiLik> likovi = new List<GeometrijskiLik>();
    }
}
