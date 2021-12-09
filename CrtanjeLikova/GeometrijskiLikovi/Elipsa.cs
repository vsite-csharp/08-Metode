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
        public Elipsa(float x, float y, float širina, float visina, Color bojaOkvira, Color bojaPopune)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaOkvira = bojaOkvira;
            this.bojaPopune = bojaPopune;
        }
        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(new Pen(bojaOkvira), x, y, širina, visina);
        }

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
            g.FillEllipse(new SolidBrush(bojaPopune), x, y, širina, visina);
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
        private Color bojaOkvira;
        private Color bojaPopune;
    }
}
