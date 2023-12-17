namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    abstract class GeometrijskiLik
    {
        // :093 Dodati zaštićene apstraktne metode Popuni i NacrtajOkvir.
        public abstract void Popuni(Graphics g, Color boja);
        public abstract void NacrtajOkvir(Graphics g, Color boja);

        // :094 Apstraktnu metodu Nacrtaj nadomjestiti nevirtualnom metodom koja će pozivati apstraktne metode Popuni i NacrtajOkvir.
        //public abstract void Nacrtaj(System.Drawing.Graphics g);

        // :095 U izvedenim klasama ukloniti metodu Nacrtaj te implementirati metode Popuni i NacrtajOvir.

        // :096 Dodati u konstruktore boju okvira i boju popune te ih upotrijebiti za iscrtavanje.

        public abstract void Pomakni(float deltaX, float deltaY);

        public abstract void Uvećaj(float faktor);
    }
}
