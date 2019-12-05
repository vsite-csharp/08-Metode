namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    abstract class GeometrijskiLik
    {
        
        public abstract void Nacrtaj(System.Drawing.Graphics g);


        public abstract void Pomakni(float deltaX, float deltaY);

        public abstract void Uvećaj(float faktor);
    }
}
