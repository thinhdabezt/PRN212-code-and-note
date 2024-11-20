using BookManagement.BLL.Services;
using BookManagement.DLL.Models;
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
    /// Interaction logic for BookDetailWindow.xaml
    /// </summary>
    public partial class BookDetailWindow : Window
    {
        private CategoryService _categoryService = new CategoryService();
        private BookService _bookService = new BookService();
        public Book Selected { get; set; }
        public BookDetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookIdTextBox.IsEnabled = false;
            BookCategoryIdComboBox.ItemsSource = _categoryService.GetAll();
            BookCategoryIdComboBox.DisplayMemberPath = "BookGenreType";
            BookCategoryIdComboBox.SelectedValuePath = "BookCategoryId";
            if (Selected == null)
            {
                WindowModeLabel.Content = "Create Book";
                return;
            }

            BookIdTextBox.Text = Selected.BookId.ToString();
            BookNameTextBox.Text = Selected.BookName.ToString();
            DescriptionTextBox.Text = Selected.Description;
            PublicationDateDatePicker.SelectedDate = Selected.PublicationDate;
            QuantityTextBox.Text = Selected.Quantity.ToString();
            PriceTextBox.Text = Selected.Price.ToString();
            AuthorTextBox.Text = Selected.Author;
            BookCategoryIdComboBox.SelectedValue = Selected.BookCategoryId;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Book obj = new Book();
            obj.BookName = BookNameTextBox.Text;
            obj.Description = DescriptionTextBox.Text;
            obj.PublicationDate = (DateTime)PublicationDateDatePicker.SelectedDate;
            obj.Quantity = int.Parse(QuantityTextBox.Text);
            obj.Price = double.Parse(PriceTextBox.Text);
            obj.Author = AuthorTextBox.Text;
            obj.BookCategoryId = (int)BookCategoryIdComboBox.SelectedValue;

            if (Selected == null)
            {
                _bookService.Create(obj);
            }
            else
            {
                obj.BookId = int.Parse(BookIdTextBox.Text);
                _bookService.Update(obj);
            }
            this.Close();
        }
    }
}
