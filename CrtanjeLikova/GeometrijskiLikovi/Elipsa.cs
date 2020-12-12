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
        private float x;
        private float y;
        private float širina;
        private float visina;
        private Brush bojaUnutra;
        private Pen bojaOkvira;
        public Elipsa(float x, float y, float širina, float visina, Brush bojaUnutra, Pen bojaOkvira)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaUnutra = bojaUnutra;
            this.bojaOkvira = bojaOkvira;
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
        protected override void NactrajOkvir(System.Drawing.Graphics g)
        {
            g.DrawEllipse(bojaOkvira, x, y, širina, visina);
        }

        protected override void Popuni(System.Drawing.Graphics g)
        {
            g.FillEllipse(bojaUnutra, x, y, širina, visina);
        }
    }
}
