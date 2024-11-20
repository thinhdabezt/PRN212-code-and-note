using BookManagement.BLL.Service;
using BookManagement.DAL.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookManagement_TranDinhThinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserAccount User { get; set; }
        private BookService _service = new BookService();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HelloLabel.Content = $"Hello, {User.FullName}";
            BookDataGrid.ItemsSource = _service.GetAll();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Book book = BookDataGrid.SelectedItem as Book;
            if (book == null )
            {
                MessageBox.Show("Please select a book first!", "Select One", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Book book = BookDataGrid.SelectedItem as Book;
            if (book == null)
            {
                MessageBox.Show("Please select a book first!", "Select One", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DetailWindow detail = new DetailWindow();
            detail.Book = book;
            detail.ShowDialog();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detail = new DetailWindow();
            detail.ShowDialog();
        }
    }
}