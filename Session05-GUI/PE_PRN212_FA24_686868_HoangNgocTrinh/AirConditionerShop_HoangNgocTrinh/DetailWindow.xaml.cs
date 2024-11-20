using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Models;
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

        //ta chế thêm trong class này 1 prop để hứng cái selected aircon từ bên mainwindow chuyển sang ở mode update
        //tức là ta cần edit 1 info của 1 aircon nào đó, cho nên ở class này ta cần phải có biến lưu máy lạnh cần edit

        //còn màn hình create, không cần prop này, vì create mode là màn hình trắng trơn
        //prop này đóng thêm vai trò biến flag, để biết mode của class này là mode gì
        //nhờ flag, ta biết đc nút save này khi nhấn sẽ gọi hàm insert into hay hàm update from của service
        //do 1 màn hình vừa xài create vừa xài update

        public AirConditioner EditedOne { get; set; }
        //new class này mà không nói gì cả thì = null;

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
            //nếu user chọn 1 supplier  thì cái value của cột supplierid thì sẽ đc l`1ưu vào thằng .selecteditem

            if(EditedOne == null)
            {
                DetailWindowModeLabel.Content = "Create Air Conditioner";
                return;
            }

            DetailWindowModeLabel.Content = "Update Air Conditioner";
            //đổ data của object vào gui
            AirConditionerIdTextBox.Text = EditedOne.AirConditionerId.ToString();
            AirConditionerIdTextBox.IsEnabled = false;
            AirConditionerNameTextBox.Text = EditedOne.AirConditionerName;
            WarrantyTextBox.Text = EditedOne.Warranty;
            SoundPressureLevelTextBox.Text = EditedOne.SoundPressureLevel;
            FeatureFunctionTextBox.Text = EditedOne.FeatureFunction;
            QuantityTextBox.Text = EditedOne.Quantity.ToString();
            DollarPriceTextBox.Text = EditedOne.DollarPrice.ToString();
            SupplierIdComboBox.SelectedValue = EditedOne.SupplierId;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ////in thử id thằng supplier đc chọn
            //MessageBox.Show("Id của supplier mà bạn đã chọn: " + SupplierIdComboBox.SelectedValue.ToString());
            //nút save xài chung cho create và update nên ta phải phân biệt khi nào create khi nào update
            //có prop editedone, = null -> tạo mới
            //                  != null -> update
            //kiểu gì thì kiểu, phải có object để gửi xuống

            //AirConditioner obj = new AirConditioner()
            //{
            //    AirConditionerId = int.Parse(AirConditionerIdTextBox.Text),
            //    AirConditionerName = AirConditionerNameTextBox.Text,
            //    Warranty = WarrantyTextBox.Text,
            //    SoundPressureLevel = SoundPressureLevelTextBox.Text,
            //    FeatureFunction = FeatureFunctionTextBox.Text,
            //    Quantity = int.Parse(QuantityTextBox.Text),
            //    DollarPrice = double.Parse(DollarPriceTextBox.Text),
            //};

            if (!Check())
            {
                return;
            }

            AirConditioner obj = new AirConditioner();
            obj.AirConditionerId = int.Parse(AirConditionerIdTextBox.Text);
            obj.AirConditionerName = AirConditionerNameTextBox.Text;
            obj.Warranty = WarrantyTextBox.Text;
            obj.SoundPressureLevel = SoundPressureLevelTextBox.Text;
            obj.FeatureFunction = FeatureFunctionTextBox.Text;
            obj.Quantity = int.Parse(QuantityTextBox.Text);
            obj.DollarPrice = double.Parse(DollarPriceTextBox.Text);
            obj.SupplierId = SupplierIdComboBox.SelectedValue.ToString();

            if(EditedOne == null)
            {
                _airConservice.CreateAirCon(obj);
            }
            else
            {
                _airConservice.UpdateAirCon(obj);
            }

            this.Close();
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(AirConditionerNameTextBox.Text))
            {
                MessageBox.Show("Please fill air-con name filed!", "Field Reqiured", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (AirConditionerNameTextBox.Text.Trim().Length < 5 || AirConditionerNameTextBox.Text.Trim().Length > 90)
            {
                MessageBox.Show("Air-con name must between 5 and 90 characters!", "Lenght Reqiured", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string airConName = AirConditionerNameTextBox.Text.Trim();
            AirConditionerNameTextBox.Text = textInfo.ToTitleCase(airConName.ToLower());

            if (!int.TryParse(QuantityTextBox.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a number!", "Number Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if(quantity < 5 || quantity > 100)
            {
                MessageBox.Show("Quantity must be between 5 and 100", "Number Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
    }
}
