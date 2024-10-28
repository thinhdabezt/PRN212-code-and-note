using AirConditionerShop.BLL.Services;
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

namespace AirConditionerShop_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        //màn hình này cần 2 service
        //aircon service để crud trên table aircon
        //supplier để getall để fill vào combobox
        private AirConService _airConservice = new();
        private SupplierService _supplierService = new();

        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //1. fill combobox supplier để sẵn cho user lựa chọn lúc tạo mới máy lạnh
            //2. nếu tạo mới, để màn hình trắng
            //3. nếu là edit thì phải show full info của thằng selecteditem
            //khi edit thì phải nhảy đến cái supplier mà cái thằng selecteditem đang thuộc về

            //1.
            SupplierIdComboBox.ItemsSource = _supplierService.GetAll(); //phải chọn cột để show, để lấy fk dùng sau này
            SupplierIdComboBox.DisplayMemberPath = "SupplierName";
            SupplierIdComboBox.SelectedValuePath = "SupplierId";
            //nếu user chọn 1 supplier  thì cái value của cột supplierid thì sẽ đc lưu vào thằng .selecteditem
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //in thử id thằng supplier đc chọn
            MessageBox.Show("Id của supplier mà bạn đã chọn: " + SupplierIdComboBox.SelectedValue.ToString());
        }
    }
}
