using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    internal class Elipsa : GeometrijskiLik
    {
        private float centerX;
        private float centerY;
        private float radiusX;
        private float radiusY;
        private Color fillColor;
        private Color outlineColor;

        public Elipsa(float centerX, float centerY, float radiusX, float radiusY, Color fillColor, Color outlineColor)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radiusX = radiusX;
            this.radiusY = radiusY;
            this.fillColor = fillColor;
            this.outlineColor = outlineColor;
        }
        /*public override void Nacrtaj(Graphics g)
        {
            using (Brush brush = new SolidBrush(fillColor))
            using (Pen pen = new Pen(outlineColor, 2))
            {
                g.FillEllipse(brush, centerX - radiusX, centerY - radiusY, 2 * radiusX, 2 * radiusY);
                g.DrawEllipse(pen, centerX - radiusX, centerY - radiusY, 2 * radiusX, 2 * radiusY);
            }
        }*/
        public override void Popuni(Graphics g, Color boja)
        {
            using (Brush brush = new SolidBrush(boja))
            {
                g.FillEllipse(brush, centerX - radiusX, centerY - radiusY, 2 * radiusX, 2 * radiusY);
            }
        }

        public override void NacrtajOkvir(Graphics g, Color boja)
        {
            using (Pen pen = new Pen(boja, 2))
            {
                g.DrawEllipse(pen, centerX - radiusX, centerY - radiusY, 2 * radiusX, 2 * radiusY);
            }
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            centerX += deltaX;
            centerY += deltaY;
        }

        public override void Uvećaj(float faktor)
        {
            radiusX *= faktor;
            radiusY *= faktor;
        }
    }
}
