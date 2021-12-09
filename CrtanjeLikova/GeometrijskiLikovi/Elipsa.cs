using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.CSharp.Metode.GeometrijskiLikovi;

namespace Vsite.CSharp.Metode
{
    class Elipsa : GeometrijskiLik
    {
        public Elipsa(float x, float y, float širina, float visina)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
        }

        protected override void Popuni(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Magenta), x, y, širina, visina);
        }
        protected override void NacrtajOkvir(Graphics g)
        {
            g.DrawEllipse(Pens.Navy, x, y, širina, visina);
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            throw new NotImplementedException();
        }

        public override void Uvećaj(float faktor)
        {
            throw new NotImplementedException();
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
    }
}
