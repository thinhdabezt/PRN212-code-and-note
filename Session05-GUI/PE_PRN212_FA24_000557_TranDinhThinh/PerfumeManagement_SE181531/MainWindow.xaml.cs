using Perfume.BLL.Services;
using Perfume.DAL;
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

namespace PerfumeManagement_SE181531
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Psaccount User { get; set; }
        private PerfumeService _perService = new PerfumeService();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Main_Window_Loaded(object sender, RoutedEventArgs e)
        {
            Fill();
        }

        public void Fill()
        {
            HelloLabel.Content = $"Hello, {User.PsaccountNote}";
            if(User.Role == 3)
            {
                CreateButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }

            PerfumeDataGrid.ItemsSource = null;
            PerfumeDataGrid.ItemsSource = _perService.GetAll();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            PerfumeInformation selected = PerfumeDataGrid.SelectedItem as PerfumeInformation;

            if (selected == null)
            {
                MessageBox.Show("Please select a perfume first!", "Selected Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(answer != MessageBoxResult.Yes)
            {
                return;
            }

            _perService.Delete(selected);
            Fill();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            PerfumeInformation selected = PerfumeDataGrid.SelectedItem as PerfumeInformation;

            if (selected == null)
            {
                MessageBox.Show("Please select a perfume first!", "Selected Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DetailWindow detail = new DetailWindow();
            detail.Selected = selected;
            detail.ShowDialog();

            Fill();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detail = new DetailWindow();
            detail.ShowDialog();

            Fill();
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