using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    class Elipsa:GeometrijskiLik
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
            g.FillRectangle(new SolidBrush(Color.Blue), x, y, širina, visina);
        }

        protected override void NacrtajOkvir(Graphics g)
        {
            throw new NotImplementedException();
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
    }
    

}
