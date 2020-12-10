using System.Drawing;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    internal class Elipsa : GeometrijskiLik
    {
        private int x;
        private int y;
        private int širina;
        private int visina;

        public Elipsa(int x, int y, int širina, int visina)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
        }

        public override void Nacrtaj(Graphics g)
        {
            throw new System.NotImplementedException();
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            throw new System.NotImplementedException();
        }

        public override void Uvećaj(float faktor)
        {
            throw new System.NotImplementedException();
        }

        protected override void Popuni()
        {
            throw new System.NotImplementedException();
        }
    }
}