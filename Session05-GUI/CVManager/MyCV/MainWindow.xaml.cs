using MyCV.Entities;
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

namespace MyCV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            //ta sẽ chuẩn bị nhiều data đổ vào cái lưới
            //data: đến từ table trong database
            //      cất trữ vào trong List<CV>
            //cái lưới tên là CVListDataGrid, đằng sau nó là chính là class
            //data qua property .ItemSource = list mình chuẩn bị, thế là nó tự generate column, tự show data vào đúng cột
            //cái grid này nó tự biết tự tách cột, tách dòng
            //mỗi cv là một dòng của grid
            List<CV> arr = new List<CV>();
            arr.Add(new CV()
            {
                Id = "C01",
                Name = "An Hoang",
                Yob = 2004,
                Position = "Back-end Intern"
            });
            arr.Add(new CV()
            {
                Id = "C02",
                Name = "Binh Nguyen",
                Yob = 2004,
                Position = "Front-end Intern"
            });
            arr.Add(new CV()
            {
                Id = "C03",
                Name = "Cuong Vo",
                Yob = 2004,
                Position = "Full-stack .NET"
            });

            CVListDataGrid.ItemsSource = arr;
        }
    }
}