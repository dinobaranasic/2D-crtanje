using System;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace MEV_Paint_Vjezba.GrafickiOblici
{
    class Pravokutnik : GrafickiOblik
    {
        public Pravokutnik()
        {
            oblik = new Rectangle();
        }

        public override void Nacrtaj()
        {
            base.Nacrtaj();
            //razlike
            oblik.Width = Math.Abs(startPoint.X - endPoint.X);
            oblik.Height = Math.Abs(startPoint.Y - endPoint.Y);
            Canvas.SetTop(oblik, Math.Min(startPoint.Y, endPoint.Y));
            Canvas.SetLeft(oblik, Math.Min(startPoint.X, endPoint.X));
        }
    }
}
