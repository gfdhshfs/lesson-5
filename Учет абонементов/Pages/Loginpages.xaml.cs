using Library;
using System.Windows;
using System.Windows.Controls;

namespace Учет_абонементов.Pages
{
    /// <summary>
    /// Логика взаимодействия для Loginpages.xaml
    /// </summary>
    public partial class Loginpages : Page
    {
        public Loginpages()
        {
            InitializeComponent();

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                var login = LoginTextBox.Text.Trim();

                var password = PasswordTextBox.Text.Trim();

                var loginStatus = LoginServise.Login(login, password);


            }

        }
    }
}
