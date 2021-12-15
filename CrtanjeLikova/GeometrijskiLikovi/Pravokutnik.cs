using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        public Pravokutnik(float x, float y, float širina, float visina, Color bojaPopune, Color bojaOkvira)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaOkvira = bojaOkvira;
            this.bojaPopune = bojaPopune;
        }

        protected override void Popuni(Graphics g)
        {
            g.FillRectangle(new SolidBrush(bojaPopune),x, y, širina, visina);
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawRectangle(new Pen(bojaOkvira), x, y, širina, visina);
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
        private Color bojaOkvira;
    }
}
