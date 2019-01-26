using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MEV_Paint_Vjezba.GrafickiOblici
{
    public class GrafickiOblik
    {
        // krajnje točke
        protected Point startPoint;
        protected Point endPoint;
        // boja
        protected Brush boja;
        // linija
        protected double debljinaLinije;
        protected Brush bojaLinije;
        // kanvas na koji se postavlja
        protected Canvas kanvas;
        // oblik koji postavljamo
        protected Shape oblik;

        // zadavanje oblika
        public virtual void Postavi(Canvas kanvas, Point pocetak, Point kraj, Brush boja, double debljinaLinije, Brush bojaLinije)
        {
            this.kanvas = kanvas;
            this.boja = boja;
            this.debljinaLinije = debljinaLinije;
            this.bojaLinije = bojaLinije;
            startPoint = pocetak;
            endPoint = kraj;
        }

        // crtanje oblika
        public virtual void Nacrtaj()
        {
            // ako ne postoji na kanvasu, dodaj ga
            if (!kanvas.Children.Contains(oblik)) kanvas.Children.Add(oblik);

            //ono sto je zajednicko svim objektima
            oblik.Stroke = bojaLinije;
            oblik.StrokeThickness = debljinaLinije;
            oblik.Fill = boja;
        }
    }
}
