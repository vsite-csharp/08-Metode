using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik // Ctrl + . na podcrtani Elipsa -> Implement abstract class
    {
        private float x;
        private float y;
        private float širina;
        private float visina;

        public override void Nacrtaj(Graphics g)
        {
            g.DrawEllipse(Pens.Black, x, y, širina, visina);
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            throw new NotImplementedException();
        }

        public override void Uvećaj(float faktor)
        {
            throw new NotImplementedException();
        }
    }
}
