using Codev_V2;
using Codev_V2.Páginas;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Codev_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Fechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Clientes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Inicio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Conta_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Inicio());
        }
        private void Sobre_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            new Splash().Show();
            Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var fade = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(100)
            };

            BeginAnimation(OpacityProperty, fade);
        }
    }
}