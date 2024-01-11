using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik
    {
        private float x;
        private float y;
        private float w;
        private float h;
        private Color b;
        private Color i;

        public Elipsa(float x, float y, float width, float height, Color border, Color infill)
        {
            this.x = x;
            this.y = y;
            this.w = width;
            this.h = height;
            this.b = border;
            this.i = infill;
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            x += deltaX;
            y += deltaY;
        }

        public override void Uvećaj(float faktor)
        {
            w *= faktor;
            h *= faktor;
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(new Pen(b), x, y, w, h);
        }

        protected override void Popuni(Graphics g)
        {
            g.FillEllipse(new SolidBrush(i), x, y, w, h);
        }
    }
}
