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
        private float width;
        private float height;
        private Pen border;
        private Brush fill;
        public Elipsa(float x, float y, float width, float height,Pen border,Brush fill)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.border = border;
            this.fill = fill;
        }
        public override void Pomakni(float deltaX,float deltaY)
        {
            x += deltaX;
            y += deltaY;
        }

      

        public override void Uvećaj(float faktor)
        {
            this.width *= faktor;
            this.height *= faktor;
        }
        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(border, x, y, width, height);
        }
        protected override void Popuni(Graphics g)
        {
            g.FillEllipse(fill, x, y, width, height);
        }
        
    }
}
