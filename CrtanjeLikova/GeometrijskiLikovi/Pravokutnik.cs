using System.Drawing;
using System.Drawing.Drawing2D;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        public Pravokutnik(float x, float y, float širina, float visina, Pen border, Brush fill)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.border = border;
            this.fill = fill;
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawRectangle(border, x, y, širina, visina);
        }

        protected override void Popuni(Graphics g)
        {
            g.FillRectangle(fill, x, y, širina, visina);
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
        private Pen border;
        private Brush fill;
    }
}
