using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik // override kao virtualne, izvedena iz geometrijski lik
        // ctrl + k + d -> formatiraj lijepo 
    {
        // public override sve metode
        public Elipsa(float x, float y, float širina, float visina, Color bojaOkvira, Color bojaPopune)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaOkvira = bojaOkvira;
            this.bojaPopune = bojaPopune;
        }
        protected override void Popuni(Graphics g)
        {
            g.FillEllipse(new SolidBrush(bojaPopune), x, y, širina, visina);
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(new Pen(bojaOkvira), x, y, širina, visina);
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            x += deltaX;
            y += deltaY;
        }

        public override void Uvećaj(float faktor)
        {
            širina *= faktor;
            visina *= faktor;
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
        private Color bojaOkvira;
        private Color bojaPopune;

    }
}
