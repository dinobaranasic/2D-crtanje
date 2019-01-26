using MEV_Paint_Vjezba.GrafickiOblici;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MEV_Paint_Vjezba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point startPoint;
        private Point endPoint;
        //oblik koji se trenutno crta
        private GrafickiOblik sjena;

        //vrsta oblika
        private VrstaOblika vrsta = VrstaOblika.Linija;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void PravokutnikButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Pravokutnik;
        }

        private void ElipsaButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Elipsa;
        }

        private void LinijaButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Linija;
        }

        private void KrugButton_Click(object sender, RoutedEventArgs e)
        {
            vrsta = VrstaOblika.Krug;
        }



        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //zapisivanje kordinate
            endPoint = e.GetPosition(PlocaCanvas);
            //ispisivanje koordinate
            KoordinateTextBox.Text = endPoint.X.ToString() + " / " + endPoint.Y.ToString();

            
            //Ako postoji sjena - osvježi je
            if (sjena != null)
            {
                sjena.Postavi(PlocaCanvas, startPoint, endPoint, BojaTextBox.Background, double.Parse(LinijeTextBox.Text), Brushes.Black);
                sjena.Nacrtaj();
            }
        }



        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Pocetna tocka objekta kojeg crtamo
            startPoint = e.GetPosition(PlocaCanvas);
            if(sjena == null)
            {
                sjena = KreatorOblika.KreirajOblik(vrsta);
            }
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //zaboravi na trenutni oblik
            sjena = null;
        }

        private void BojaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //podesavanje boje pozadine textBoxa
            try
            {
                var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(BojaTextBox.Text));
                BojaTextBox.Background = brush;
            }
            catch
            {

            }
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            //brisanje elemenata undo
            if (PlocaCanvas.Children.Count > 0)
            {
                PlocaCanvas.Children.RemoveAt(PlocaCanvas.Children.Count - 1);
            }

        }

        
    }
}
