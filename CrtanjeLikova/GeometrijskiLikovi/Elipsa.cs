using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik
    {
        public Elipsa(float x, float y, float širina, float visina, Brush popun, Pen obrub)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
            this.popun = popun;
            this.obrub = obrub;
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
        private Brush popun;
        private Pen obrub;


        protected override void Popuni(System.Drawing.Graphics g)
        {
            g.FillEllipse(popun, x, y, širina, visina);
        }

        protected override void NacrtajOkvir(System.Drawing.Graphics g)
        {
            g.DrawEllipse(obrub, x, y, širina, visina);
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
