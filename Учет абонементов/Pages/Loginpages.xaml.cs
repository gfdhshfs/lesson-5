using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
