using BookManagement.BLL.Services;
using BookManagement.DLL.Models;
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

namespace BookManagement_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookService _service = new BookService();

        public UserAccount LoginUser { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BookMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FillGrid(_service.GetAll());
            if(LoginUser.Role == 2)
            {
                CreateButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }

        public void FillGrid(List<Book> list)
        {
            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = list;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Book selected = BookListDataGrid.SelectedItem as Book;
            if(selected == null)
            {
                MessageBox.Show("Please select an item!", "Item Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var choice = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(choice == MessageBoxResult.Yes)
            {
                _service.Delete(selected);
                FillGrid(_service.GetAll());
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Book selected = BookListDataGrid.SelectedItem as Book;
            if (selected == null)
            {
                MessageBox.Show("Please select an item!", "Item Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            BookDetailWindow detail = new BookDetailWindow();
            detail.Selected = selected;
            detail.ShowDialog();
            FillGrid(_service.GetAll());
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            BookDetailWindow detail = new BookDetailWindow();
            detail.ShowDialog();
            FillGrid(_service.GetAll());
        }
    }
}