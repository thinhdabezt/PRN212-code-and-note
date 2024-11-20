using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Models;
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

namespace AirConditionerShop_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AirConService _service = new();
        public StaffMember User { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HelloMsgLabel.Content = $"Hello, {User.FullName}";

            if(User.Role == 2)
            {
                CreateButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }

            AirCondDataGrid.ItemsSource = _service.GetAllAirCons();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            //nhấn nút create thì mở form detail trắng trơn, để user gõ thông tin của 1 máy lạnh mới
            //mỗi của sổ bản chất là 1 class => khai báo mới và new
            DetailWindow detail = new DetailWindow();
            detail.ShowDialog(); //làm xong mới quay về
            FillDataGrid(_service.GetAllAirCons());

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //khi người dùng nhấn nut update phải check xem user đã chọn dòng chưa, không chọn lấy gì edit
            //khi chọn 1 dòng tử tế, không phải dòng trắng ở đáy thì cái datagrid nó đc thiết kế để lắng nghe user làm gì với nó, nếu user chọn 1 dòng khác dòng trắng, thì nó ngay lập tức set prop tên là selecteditem = trỏ đến cái object đc chọn
            //.selecteditem chính là cái máy lạnh trong ram đc focus
            //còn nếu chọn dòng trắng hay không chọn => .selecteditem = null
            //đó là căn cứ để ta quyết định hành động tiếp theo
            AirConditioner selected = AirCondDataGrid.SelectedItem as AirConditioner;
            //as ~ ép kiểu từ object thành class cụ thể, ép không đc thì gán null
            //   ~ (AirConditioner), những ép kiểu này dễ bị exeption

            if (selected == null)
            {
                MessageBox.Show("Please select an air conditioner before updating!", "Select one", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            //in thử xem có đúng máy lạnh vừa chọn không
            //MessageBox.Show("Air conditioner: " + selected.AirConditionerId + " | " + selected.AirConditionerName);

            DetailWindow detail = new DetailWindow();
            //phải gửi thằng selected sang màn hình detail
            detail.EditedOne = selected; //2 chàng 1 nàng
            detail.ShowDialog();
            //cửa sổ chưa tắt thì lệnh dưới chưa chạy
            FillDataGrid(_service.GetAllAirCons());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner selected = AirCondDataGrid.SelectedItem as AirConditioner;

            if (selected == null)
            {
                MessageBox.Show("Please select an air conditioner before deleting!", "Select one", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            //confirm trước rồi mới xóa
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(answer == MessageBoxResult.No)
                return;

            _service.DeleteAirCon(selected);
            //xóa xong phải f5 vì grid nó chơi với ram, không có đồng bộ với db
            //cực kỳ quan trọng: create, update, delete đều phải f5 cái grid, chưa kể mở màn hình này cũng phải f5
            //lặp lại gì đó => tách hàm
            FillDataGrid(_service.GetAllAirCons());
        }

        //hàm helper
        private void FillDataGrid(List<AirConditioner> list)
        {
            //xóa lưới cũ, đổ lưới mới
            AirCondDataGrid.ItemsSource = null; //xóa data cũ
            AirCondDataGrid.ItemsSource = list; //fill data = data mới đưa vào
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}