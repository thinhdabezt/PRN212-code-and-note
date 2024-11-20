using Perfume.BLL.Services;
using Perfume.DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public PerfumeInformation Selected { get; set; }

        private CompanyService _compService = new CompanyService();
        private PerfumeService _perService = new PerfumeService();
        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductionCompanyIDComboBox.ItemsSource = _compService.GetAll();
            ProductionCompanyIDComboBox.DisplayMemberPath = "ProductionCompanyName";
            ProductionCompanyIDComboBox.SelectedValuePath = "ProductionCompanyId";

            if(Selected == null)
            {
                DetailWindowModeLabel.Content = "Create Perfume";
                return;
            }

            DetailWindowModeLabel.Content = "Update Perfume";

            IdTextBox.Text = Selected.PerfumeId;
            IdTextBox.IsEnabled = false;
            NameTextBox.Text = Selected.PerfumeName;
            IngredientsTextBox.Text = Selected.Ingredients;
            ReleaseDate.SelectedDate = Selected.ReleaseDate;
            ConcentrationTextBox.Text = Selected.Concentration;
            LongevityTextBox.Text = Selected.Longevity;
            ProductionCompanyIDComboBox.SelectedValue = Selected.ProductionCompanyId;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            PerfumeInformation obj = new PerfumeInformation();
            obj.PerfumeId = IdTextBox.Text;
            obj.PerfumeName = NameTextBox.Text;
            obj.Ingredients = IngredientsTextBox.Text;
            obj.ReleaseDate = ReleaseDate.SelectedDate;
            obj.Concentration = ConcentrationTextBox.Text;
            obj.Longevity = LongevityTextBox.Text;
            obj.ProductionCompanyId = (string)ProductionCompanyIDComboBox.SelectedValue;

            if (!Check())
            {
                return;
            }

            if(Selected == null)
            {
                _perService.Create(obj);
            }
            else
            {
                _perService.Update(obj);
            }

            this.Hide();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                this.Hide();
            }
        }

        public bool Check()
        {
            if (string.IsNullOrWhiteSpace(IdTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(IngredientsTextBox.Text) || ReleaseDate.SelectedDate == null || string.IsNullOrWhiteSpace(ConcentrationTextBox.Text) || string.IsNullOrWhiteSpace(LongevityTextBox.Text) || ProductionCompanyIDComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please fill all field!", "Field Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            string name = NameTextBox.Text.Trim();

            if(name.Length < 5 || name.Length > 90)
            {
                MessageBox.Show("Perfume name must be in range of 5 and 90 characters!", "Field Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            //TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            //NameTextBox.Text = textInfo.ToTitleCase(name.ToLower());

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            NameTextBox.Text = textInfo.ToTitleCase(name.ToLower());

            return true;
        }
    }
}
