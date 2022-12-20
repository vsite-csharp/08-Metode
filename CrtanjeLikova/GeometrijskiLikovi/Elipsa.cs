using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    internal class Elipsa : GeometrijskiLik
    {
        private float x;
        private float y;
        private float širina;
        private float visina;
        private Color bojaPopune;
        private Color bojaOkvira;

        public Elipsa(float x, float y, float širina, float visina, Color bojaPopune, Color bojaOkvira)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaPopune = bojaPopune;
            this.bojaOkvira = bojaOkvira;
        }

        protected override void Popuni(Graphics g)
        {
            Brush brush = new SolidBrush(bojaPopune);
            g.FillEllipse(brush, x, y, širina, visina);
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            Pen pen = new Pen(bojaOkvira);
            g.DrawEllipse(pen, x, y, širina, visina);
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
    }
}
