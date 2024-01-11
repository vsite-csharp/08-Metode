namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        private float x;
        private float y;
        private float širina;
        private float visina;
        private Color b;
        private Color i;

        public Pravokutnik(float x, float y, float širina, float visina, Color border, Color infill)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.b = border;
            this.i = infill;
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawRectangle(new Pen(b), x, y, širina, visina);
        }

        protected override void Popuni(Graphics g)
        {
            g.FillRectangle(new SolidBrush(i), x, y, širina, visina);
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

    }
}
