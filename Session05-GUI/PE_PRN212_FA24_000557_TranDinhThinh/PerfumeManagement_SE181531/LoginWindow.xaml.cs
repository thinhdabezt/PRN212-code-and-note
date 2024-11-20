using Perfume.BLL.Services;
using Perfume.DAL;
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
using System.Windows.Shapes;

namespace PerfumeManagement_SE181531
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private AccountService _service = new AccountService();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailAddressTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all field!", "Field Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Psaccount user = _service.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Wrong email/password!", "Invalid Account", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (user.Role != 3 && user.Role != 2)
            {
                MessageBox.Show("You have no permission to access this funtion!", "Wrong Permission", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MainWindow mainWindow = new MainWindow();
            mainWindow.User = user;
            mainWindow.Show();
            this.Hide();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
