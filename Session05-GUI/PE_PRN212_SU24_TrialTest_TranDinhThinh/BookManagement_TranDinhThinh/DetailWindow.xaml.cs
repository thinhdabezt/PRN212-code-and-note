using BookManagement.BLL.Service;
using BookManagement.DAL.Models;
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
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public Book Book { get; set; }

        private CategoryService _service = new CategoryService();
        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookGenreComboBox.ItemsSource = _service.GetAll();
            BookGenreComboBox.DisplayMemberPath = "BookGenreType";
            BookGenreComboBox.SelectedValuePath = "BookCategoryId";

            if (Book == null)
            {
                DetailWindowModeLabel.Content = "Create Window";
                return;
            }
            DetailWindowModeLabel.Content = "Update Window";
        }
    }
}
