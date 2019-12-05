namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    abstract class GeometrijskiLik
    {
        protected abstract void Popuni(System.Drawing.Graphics g);
        protected abstract void NacrtajOkvir(System.Drawing.Graphics g);

        public void Nacrtaj(System.Drawing.Graphics g)
        {
            Popuni(g);
            NacrtajOkvir(g);
        }


        // TODO:096 Dodati u konstruktore boju okvira i boju popune te ih upotrijebiti za iscrtavanje.

        public abstract void Pomakni(float deltaX, float deltaY);

        public abstract void Uvećaj(float faktor);
    }
}
