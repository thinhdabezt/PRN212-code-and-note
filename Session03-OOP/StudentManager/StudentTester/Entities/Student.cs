using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entities
    //~            java.util
{
    public class Student
    {
        private string _id;     //ID:________________________
        private string _name;   //Name:______________________
        private int _yob;       //Yob:_______________________
        private double _gpa;    //GPA:_______________________
        //class như 1 cái khuôn template, form, biểu mẫu để điền vào, blue-print(dàn khung, bản phác thảo)
        //là tên gọi chung cho 1 nhóm object chia sẻ chung nhiều đặc tính và hành vi(fields, behavior/method)
        //để có 1 object, đối tượng, ta phải điền vào form ở trên
        //trước khi điền form, ta phải photo ra 1 form trắng - new
        //sau đó ta fill, đổ info vào(tham số hàm)
        //fill vào để tạo object - contructor(tham số vật liệu đưa vào)
        //new            Student             ()
        //clone form     gọi phễu
        //xin ram        nhận vật liệu       vật liệu đưa vào
        //object này gọi tên là gì? Student tèo = , Student tí =

        //phần code còn lại y chang java
        //Contructor để đúc object
        //Các hàm Get() Set() Tostring()

        //phễu
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;       //không cần xài this. vì không có sự nhầm lẫn giữa biến đầu vào và đặc tính của object
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //các hàm truyền thống giống java
        public void FlexProfile() => Console.WriteLine($"ID: {_id} | Name: {_name} | Yob: {_yob} | GPA: {_gpa}"); //expression body
        //Console.WriteLine($"ID: {_id}");
        //Console.WriteLine($"Name: {_name}");
        //Console.WriteLine($"Yob: {_yob}");
        //Console.WriteLine($"GPA: {_gpa}");

        //object đc tạo ra tức là đã đc đổ info, giống như bạn vào ngân hàng làm phiếu rút tiền, điền phiếu rút tiền, điền xong ngắm nghía xem chữ đã rõ tên -> Get()
        //tôi biết bạn có tên, nhưng tên đang private, vậy tôi sẽ hỏi
        //GetName() -> trả về name
        public string GetName() => _name;
        public int GetAge() => 2024 - _yob;
        //harded-code - trong code có những giá trị cố định
        //gọi class rồi gọi hàm lấy giờ hệ thống - _yob

        //đổi màn hình đt, đổi avatar cover của tài khoản mxh
        //cần chuẩn bị 1 bức hình
        //nhấn nút, thay thế khung-hình-cũ = hình-mới chuẩn bị
        //Đổi Nền(Hình mới)
        //{
        //  khung-hình-cũ = hình-mới;
        //}
        //setting không tạo ra object mới mà chỉ là chỉnh sửa object cũ đã có
        
        //một sv có gpa, kì nay có điểm mới phải đc cập nhật
        public void SetGpa(double gpa) => _gpa = gpa;

        //hàm Set() và constructor giống và khác nhau ntn
        //giống: đều đổ info vào vùng ram
        //khác:
        //contructor mỗi lần gọi là 1 lần xin ram cho object, tạo object mới
        //hàm Set() mỗi lần gọi là đổ vào vùng ram cũ, đã new trước đó, chỉnh sửa vùng ram cũ đã new

        //hàm Set() là của từng object của từng mỗi object, có nhu cầu khác nhau, khi gọi đi kèm biến object
    }
}

//CODING CONVENTION - Quy tắc đặt tên trong C#
//I. TÊN CỦA SOLUTION

//II. TÊN CỦA PROJECT

//III. TÊN CỦA NAMESPACE

//IV. TÊN CỦA CLASS, INTERFACE, DELEGATES
//1. Tên class
//-DANH TỪ, CHỮ HOA TỪNG ĐẦU TỪ - Pascal  Case Notation -> BẮT CHƯỚC THEO NGÔN NGỮ LẬP TRÌNH Pascal
//VD: Student, Lecturer, Dog, Cat,...
//V. TÊN BIẾN(BIẾN CỤC BỘ, BIẾN NGOÀI HÀM/FIELDS)
//1. Biến toàn cục(field/attribute)
//-Danh từ, cú pháp con Lạc Đà , Chữ Hoa Từng Đầu Từ, từ đầu tiên viêt chữ thường kèm dấu _
//VD: _id, _name,...
//2. Biến cục bộ - local variable - biến nằm trong hàm, hoặc tham số parameter
//3. Property(biến lai hàm - làm Get Set kiểu mlem)
//Property là kỹ thuật viết hàm Get Set gọn gàng qua style xài biến, ta độ thêm 1 biến và bao cái _field qua 2 hàm Get Set xài tự nhiên qua biến lai Property
//Tên Property phải là danh từ + Pascal Case, không có động từ do Get Set bị bao bên trong
//Có nhiều kỹ thuật xài Property, từ V3 trở đi
//-Danh từ, cú pháp con lạc đà, chữ đầu tiên viết thường, những chữ còn lại chữ hoa từng đầu từ
//VD: salary, sum, count,...
//VI. TÊN HÀM(METHOD)
//VERD + OBJECT, cú pháp Pascal - Pascal Case Notation
//Chữ hoa từng đầu từ, từ đầu tiên là động từ
//VD: GetName(), ToString(), Main(), Convert(),...