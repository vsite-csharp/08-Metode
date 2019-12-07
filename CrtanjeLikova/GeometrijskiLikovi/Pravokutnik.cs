using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        public Pravokutnik(float x, float y, float širina, float visina, Pen bojaOkvira, Brush bojaIspune)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaOkvira = bojaOkvira;
            this.bojaIspune = bojaIspune;
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawRectangle(bojaOkvira, x, y, širina, visina);
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
            g.FillRectangle(bojaIspune, x, y, širina, visina);
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
        private Pen bojaOkvira;
        private Brush bojaIspune;
    }
}
