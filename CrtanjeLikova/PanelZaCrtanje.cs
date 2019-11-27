using System.Collections.Generic;
using System.Windows.Forms;
using Vsite.CSharp.Metode.GeometrijskiLikovi;

namespace Vsite.CSharp.Metode
{
    public partial class PanelZaCrtanje : System.Windows.Forms.Panel
    {
        public PanelZaCrtanje()
        {
            InitializeComponent();
        }

        public void PomakniLikove(float dx, float dy)
        {
            crtež.PomakniLikove(dx, dy);
            Invalidate();
        }

        public void UvećajLikove(float faktor)
        {
            crtež.UvećajLikove(faktor);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            crtež.Iscrtaj(pe.Graphics);
            base.OnPaint(pe);
        }

        Crtež crtež = new Crtež();
    }
}
