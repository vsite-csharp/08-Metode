using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        private float x;
        private float y;
        private float širina;
        private float visina;
        private Brush bojaUnutra;
        private Pen bojaOkvira;
        public Pravokutnik(float x, float y, float širina, float visina, Brush bojaUnutra, Pen bojaOkvira)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.bojaUnutra = bojaUnutra;
            this.bojaOkvira = bojaOkvira;
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
        protected override void NactrajOkvir(System.Drawing.Graphics g)
        {
            g.DrawRectangle(bojaOkvira, x, y, širina, visina);
        }

        protected override void Popuni(System.Drawing.Graphics g)
        {
            g.FillRectangle(bojaUnutra, x, y, širina, visina);
        }
    }
}
