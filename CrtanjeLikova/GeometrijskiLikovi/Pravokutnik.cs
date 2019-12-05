using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        public Pravokutnik(float x, float y, float širina, float visina, Brush brush, Pen pen)
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
            g.FillRectangle(brush, x, y, širina, visina);
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawRectangle(pen, x, y, širina, visina);
        }

        private Brush brush;
        private Pen pen;
        private float x;
        private float y;
        private float širina;
        private float visina;
    }
}
