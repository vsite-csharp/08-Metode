using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    internal class Elipsa : GeometrijskiLik
    {
        private float x;
        private float y;
        private float z;
        private float v;

        public Elipsa(float x, float y, float z, float v)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.v = v;
        }

        public override void Nacrtaj(Graphics g)
        {
            g.DrawEllipse(Pens.Black, x, y, z, v);
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            x += deltaX;
            y += deltaY;
        }

        public override void Uvećaj(float faktor)
        {
            z *= faktor;
            v *= faktor;
        }
    }
}
