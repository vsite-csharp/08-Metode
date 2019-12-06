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
        private Color bojaPopune;
        private Color bojaOkvira;
        public Elipsa(float x, float y, float širina, float visina, Color bojaPop, Color bojaOkv)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaPopune = bojaPop;
            this.bojaOkvira = bojaOkv;
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

        protected override void Popuni(Graphics g)
        {
            g.FillEllipse(new SolidBrush(bojaPopune), x, y, širina, visina);
        }

        public override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(new Pen(bojaOkvira, 3), x, y, širina, visina);
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
    }
}
