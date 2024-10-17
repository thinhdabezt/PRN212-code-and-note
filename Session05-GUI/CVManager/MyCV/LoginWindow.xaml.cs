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

namespace MyCV
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello world!", "Xin chào!", MessageBoxButton.YesNo, MessageBoxImage.Asterisk);

            //gọi cửa sổ mainwindow - 1 class khác, do đó ta dùng biến object, new và .Show() như mọi class bình thường
            MainWindow myCV = new MainWindow(); //cửa sổ mới vào ram nhưng chưa render
            //. để đổi các info của object
            //render thooi
            //myCV.Show(); 
            //show kiểu này có thể mở cùng lúc nhiều cửa sổ, cứ bấm nút là mở
            //nếu mở nhiều cửa sổ giống nhau, ta sẽ khó kiểm soát dữ liệu
            //quyết định tại 1 thời điểm chỉ mở 1 cửa sổ thôi
            //gọi là show theo style giao tiếp - lắng nghe - dialog

            string userName = UsernameTextBox.Text;

            MessageBox.Show("Username: " + userName);

            myCV.ShowDialog();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                //tắt app
                Application.Current.Shutdown();
            }
        }
    }
}
