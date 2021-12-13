using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik // geometrijski lik je abstraktna klasa 
    {

        private float x;
        private float y;
        private float širina;
        private float visina;
        private Pen border = Pens.Black;
        private Brush fill = Brushes.YellowGreen; 

        public Elipsa(float x, float y, float širina, float visina, Pen border, Brush fill)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.border = border;
            this.fill = fill; 
        }

        public Elipsa(float x, float y, float širina, float visina)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            //this.border = border;
            //this.fill = fill;
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(border, x, y, širina, visina);
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            x += deltaX;
            y += deltaY;
        }

        public override void Uvećaj(float faktor)
        {
            this.širina *= faktor;
            this.visina *= faktor;
        }

        protected override void Popuni(Graphics g)
        {
           g.FillEllipse(fill, x, y, širina, visina);
        }
    }
}
