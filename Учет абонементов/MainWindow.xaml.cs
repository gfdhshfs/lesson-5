using System.Windows;
using Учет_абонементов.Pages;

namespace Учет_абонементов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += OpenLoginPage;
        }

        private void OpenLoginPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Loginpages());
        }
    }
}
