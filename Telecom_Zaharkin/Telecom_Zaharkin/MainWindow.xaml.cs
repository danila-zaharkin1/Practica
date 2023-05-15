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
using Telecom_Zaharkin.Model;

namespace Telecom_Zaharkin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            var user = AppData.db.enter.FirstOrDefault(enter => enter.Number == Number.Text && enter.Password == Password.Text);
            string userName = "No name";
            if (user != null)
            {
                int randomCode = new Random().Next(1, 100);
                do
                {
                    MessageBox.Show($"Random code: {randomCode}");
                    if (!string.IsNullOrEmpty(Code.Text) && int.TryParse(Code.Text, out int code) && randomCode == code)
                    {
                        userName = string.IsNullOrEmpty(user.Role) ? "No name" : user.Role;
                        MessageBox.Show($"User name: {userName}");
                        break;
                    }
                    else
                    {
                        randomCode = new Random().Next(100, 1000);
                    }
                } while (MessageBox.Show("Invalid code. Try again?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes);
            }
            else
            {
                MessageBox.Show("NOYYYYYYYYYYYY");
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
