using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.CSharp.Metode.GeometrijskiLikovi;

namespace Vsite.CSharp.Metode.GeometrijskiLikovi;
{
	class elipsa : GeometrijskiLik
	{
		public elipsa(float x, float y, float širina, float visina)
		{
			this.x = x;
			this.y = y;
			this.širina = širina;
			this.visina = visina;
		}

		public override void Nacrtaj(Graphics g)
		{
			g.DrawEllipse(Pens.Crimson, x, y, širina, visina);
		}

		public override void Pomakni(float deltaX, float deltaY)
		{
			x+=
			
		}

		public override void Uvećaj(float faktor)
		{
			throw new NotImplementedException();
		}
	}
}
