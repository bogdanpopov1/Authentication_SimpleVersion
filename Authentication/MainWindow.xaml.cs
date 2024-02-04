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

namespace Authentication
{
    public partial class MainWindow : Window
    {
        private string login = "талгат лох";
        private string password = "это правда";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text.Trim() == String.Empty || PasswordTB.Text.Trim() == String.Empty)
            {
                if (LoginTB.Text.Trim() == String.Empty)
                    LoginTB.Background = Brushes.LightPink;
                if (PasswordTB.Text.Trim() == String.Empty)
                    PasswordTB.Background = Brushes.LightPink;
                MessageBox.Show("Все поля должны быть заполнены!");
                PasswordTB.Background = Brushes.White;
                LoginTB.Background = Brushes.White;
                return;
            }

            if (LoginTB.Text.Trim() != login &&  PasswordTB.Text.Trim() != password)
            {
                LoginTB.Background = Brushes.LightPink;
                PasswordTB.Background = Brushes.LightPink;
                MessageBox.Show("Неверные логин  и пароль!");
                PasswordTB.Background = Brushes.White;
                LoginTB.Background = Brushes.White;
                LoginTB.Clear();
                PasswordTB.Clear();
                return;
            }

            if (LoginTB.Text.Trim() != login)
            {
                LoginTB.Background = Brushes.LightPink;
                MessageBox.Show("Неверный логин!");
                LoginTB.Clear();
                LoginTB.Background = Brushes.White;
                return;
            } else
            {
                LoginTB.Background = Brushes.White;
            }

            if (PasswordTB.Text.Trim() != password)
            {
                PasswordTB.Background = Brushes.LightPink;
                MessageBox.Show("Неверный пароль!");
                PasswordTB.Clear();
                PasswordTB.Background = Brushes.White;
                return;
            } else
            {
                PasswordTB.Background = Brushes.White;
            }

            LoginTB.Background = Brushes.LightGreen;
            PasswordTB.Background = Brushes.LightGreen;

            MessageBox.Show($"Добрый день, {login}!\nРады, что Вы с нами!");

            LoginTB.Clear();
            PasswordTB.Clear();
            PasswordTB.Background = Brushes.White;
            LoginTB.Background = Brushes.White;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
