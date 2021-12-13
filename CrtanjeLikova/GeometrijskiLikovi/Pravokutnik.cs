using System.Drawing;
using System.Drawing.Configuration;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        public Pravokutnik(float x, float y, float širina, float visina, Color bojaPopune, Pen bojaOkvira)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaPopune = bojaPopune;
            this.bojaOkvira = bojaOkvira;
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawRectangle(this.bojaOkvira, x, y, širina, visina);
        }

        protected override void Popuni(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.bojaPopune), x, y, širina, visina);
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
        private Color bojaPopune;
        private Pen bojaOkvira;
    }
}
