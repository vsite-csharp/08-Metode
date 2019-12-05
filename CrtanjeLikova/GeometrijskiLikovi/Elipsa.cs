﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik
    {
        public Elipsa(float x, float y, float širina, float visina, Brush brush, Pen pen)
        {
            this.brush = brush;
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
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
            g.FillEllipse(brush, x,y,širina,visina);        
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(pen, x, y, širina, visina);     
        }

        private Brush brush;
        private Pen pen;
        private float x;
        private float y;
        private float širina;
        private float visina;
    }
}
