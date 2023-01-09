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
        }

        protected override void Popuni(Graphics g)
        {
            Brush brush = new SolidBrush(bojaPopune);
            g.FillRectangle(brush, x, y, širina, visina);
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            Pen pen = new Pen(bojaOkvira);
            g.DrawRectangle(pen, x, y, širina, visina);
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
