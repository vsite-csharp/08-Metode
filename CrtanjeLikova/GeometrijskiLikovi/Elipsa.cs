using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik
    {
        public Elipsa(float x, float y, float širina, float visina, Pen bojaLinije, Color bojaIspune)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaLinije = bojaLinije;
            this.bojaIspune = bojaIspune;
        }
        protected override void Popuni(Graphics g)
        {
            g.FillEllipse(new SolidBrush(bojaIspune), x, y, širina, visina);
        }
        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(bojaLinije, x, y, širina, visina);
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
        private Pen bojaLinije;
        private Color bojaIspune;
    }
}
