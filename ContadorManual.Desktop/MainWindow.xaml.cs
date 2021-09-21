using System.Windows;

namespace ContadorManual.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _Conteo;
        public MainWindow()
        {
            InitializeComponent();
            _Conteo = 0;
        }

        private void ContarButton_Click(object sender, RoutedEventArgs e)
        {
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
