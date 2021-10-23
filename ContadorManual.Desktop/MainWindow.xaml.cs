using System.Windows;
using ContadorManual.Desktop.Model;

namespace ContadorManual.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Contador contador;

        private int _Conteo;
        public MainWindow()
        {
            InitializeComponent();
            contador = new Contador()
            {
                conteoInicial = 0,
                Contar = _Conteo,
                Reiniciar = 0,
            };
            ConteoLabel.Content = contador.conteoInicial++;
            ConteoLabel.Content = contador.Contar;
            ConteoLabel.Content = contador.Reiniciar;
        }        

        private void ContarButton_Click(object sender, RoutedEventArgs e)
        {
            contador.Contar = contador.Contar.CompareTo(1);
            _Conteo++;
            ConteoLabel.Content = _Conteo;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            _Conteo = 0;
            ConteoLabel.Content = _Conteo;
        }

        private void SalirButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
