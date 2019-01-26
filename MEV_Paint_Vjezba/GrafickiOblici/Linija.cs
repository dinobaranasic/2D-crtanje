using System.Windows.Shapes;

namespace MEV_Paint_Vjezba.GrafickiOblici
{
    class Linija : GrafickiOblik
    {
        public Linija()
        {
            oblik = new Line();
        }

        public override void Nacrtaj()
        {
            base.Nacrtaj();
            // razlike
            (oblik as Line).X1 = startPoint.X;
            (oblik as Line).X2 = endPoint.X;
            (oblik as Line).Y1 = startPoint.Y;
            (oblik as Line).Y2 = endPoint.Y;
        }
    }
}
