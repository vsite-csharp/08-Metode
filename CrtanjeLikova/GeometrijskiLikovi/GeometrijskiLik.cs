namespace Vsite.CSharp.Metode.GeometrijskiLikovi
{
    abstract class GeometrijskiLik
    {
        // TODO:093 DZ Dodati zaštićene apstraktne metode Popuni i NacrtajOkvir.

        // TODO:094 DZ Apstraktnu metodu Nacrtaj nadomjestiti nevirtualnom metodom koja će pozivati apstraktne metode Popuni i NacrtajOkvir.
        public abstract void Nacrtaj(System.Drawing.Graphics g);

        // TODO:095 DZ U izvedenim klasama ukloniti metodu Nacrtaj te implementirati metode Popuni i NacrtajOvir.

        // TODO:096 DZ Dodati u konstruktore boju okvira i boju popune te ih upotrijebiti za iscrtavanje.

        public abstract void Pomakni(float deltaX, float deltaY);

        public abstract void Uvećaj(float faktor);
    }
}
