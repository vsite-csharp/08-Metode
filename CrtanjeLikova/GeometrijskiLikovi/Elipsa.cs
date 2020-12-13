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
        public Elipsa(float x, float y, float širina, float visina)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
        }
        public override void Nacrtaj(Graphics g)
        {
            Popuni(g);
            Nacrtajokvir(g);
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
            SolidBrush Brush = new SolidBrush(Color.Beige);
            g.FillEllipse(Brush, x, y, širina, visina);
        }

        protected override void Nacrtajokvir(Graphics g)
        {
            g.DrawEllipse(Pens.Black, x, y, širina, visina);
        }
    }
}
