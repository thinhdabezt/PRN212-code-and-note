using BookManagement.BLL.Services;
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

namespace BookManagement_HoangNgocTrinh
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields!", "Field Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var user = _service.Login(email, password);

            if(user == null)
            {
                MessageBox.Show("Wrong email/password!", "Invalid Account", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(user.Role == 3)
            {
                MessageBox.Show("This user do not have permission to access", "Invalid Permission", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MainWindow main = new MainWindow();
            main.LoginUser = user;
            main.Show();
            this.Hide();
        }
    }
}
