using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        private float x;
        private float y;
        private float širina;
        private float visina;
        public Pravokutnik(float x, float y, float širina, float visina)
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

        protected override void Popuni(System.Drawing.Graphics g)
        {
            SolidBrush Brush = new SolidBrush(Color.Blue);
            g.FillRectangle(Brush, x, y, širina, visina);
        }

        protected override void Nacrtajokvir(System.Drawing.Graphics g)
        {
            g.DrawRectangle(Pens.Red, x, y, širina, visina);
        }
    }
}
