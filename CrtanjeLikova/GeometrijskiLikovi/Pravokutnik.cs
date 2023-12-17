namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Pravokutnik : GeometrijskiLik
    {
        public Pravokutnik(float x, float y, float širina, float visina, Color fillColor, Color outlineColor)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.fillColor = fillColor;
            this.outlineColor = outlineColor;
        }

        /*public override void Nacrtaj(Graphics g)
        {
            using (Brush brush = new SolidBrush(fillColor))
            using (Pen pen = new Pen(outlineColor, 2))
            {
                g.FillRectangle(brush, x, y, širina, visina);
                g.DrawRectangle(pen, x, y, širina, visina);
            }
        }*/
        public override void Popuni(Graphics g, Color boja)
        {
            using (Brush brush = new SolidBrush(boja))
            {
                g.FillRectangle(brush, x, y, širina, visina);
            }
        }

        public override void NacrtajOkvir(Graphics g, Color boja)
        {
            using (Pen pen = new Pen(boja, 2))
            {
                g.DrawRectangle(pen, x, y, širina, visina);
            }
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
        private Color fillColor;
        private Color outlineColor;
    }
}
