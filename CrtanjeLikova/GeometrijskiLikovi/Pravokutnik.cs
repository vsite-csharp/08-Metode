using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        public Pravokutnik(float x, float y, float širina, float visina, Brush popun, Pen obrub)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.popun = popun;
            this.obrub = obrub;
        }

        protected override void Popuni(System.Drawing.Graphics g)
        {
            g.FillRectangle(popun, x, y, širina, visina);
        }

        protected override void NacrtajOkvir(System.Drawing.Graphics g)
        {
            g.DrawRectangle(obrub, x, y, širina, visina);
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
        private Brush popun;
        private Pen obrub;
    }
}
