using BookManagement.BLL.Service;
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

namespace BookManagement_TranDinhThinh
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UserService _service = new UserService();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(EmailAddressTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Please fill all fields", "Fields Reqiured", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string email = EmailAddressTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            var user = _service.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Invalid email/password", "Invalid Account", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(user.Role == 3)
            {
                MessageBox.Show("You have no permission to access this function!", "Invalid Permission", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MainWindow main = new MainWindow();
            main.User = user;
            main.Show();
            this.Hide();
        }
    }
}
