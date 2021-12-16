﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    internal class Elipsa : GeometrijskiLik
    {
        public Elipsa(float x, float y, float širina, float visina)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
        }
        //protected override void Nacrtaj(Graphics g)
        //{
        //    g.DrawEllipse(Pens.Violet, x, y, širina, visina);
        //}

        public override void Pomakni(float deltaX, float deltaY)
        {
            throw new NotImplementedException();
        }

        public override void Uvećaj(float faktor)
        {
            throw new NotImplementedException();
        }

        protected override void Popuni(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Aquamarine), x, y, širina, visina);
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(Pens.Violet, x, y, širina, visina);
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
    }
}
