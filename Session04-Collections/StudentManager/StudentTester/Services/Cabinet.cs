using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    //1 cái tủ thì chứa nhiều hồ sơ, có thể bổ sung thêm, bớt đi, sắp xếp -> crud method
    //Muốn chứa nhiều hồ sơ, ta cần 1 mảng....
    //Mảng đi kèm biến count để biết tủ đầy chưa
    //Giống như anh chàng ở quầy dịch vụ giữ giỏ, nhìn số chìa khóa cắm trên tủ, biết tủ full chưa
    public class Cabinet
    {
        private Student[] _arr = new Student[365];
        private int _count = 0;
        //_count tăng dần ++ khi thêm từng hồ sơ vào vị trí thứ count của mảng, ban đầu là 0, 1, 2,... đến khi mảng full
        //Tại sao k làm property
        //Mảng này fix 365, ở ngoài đời đóng tủ đa dạng kích thước, có thể theo yêu cầu, vậy tui phải làm sao để tủ đóng theo yêu cầu

        //public Cabinet(int size)
        //{
        //    if (size < 1) throw new ArgumentOutOfRangeException("Invalid size! Size must be >= 1");

        //    _arr = new Student[size];
        //}

        //mở rộng: constructor bình thường, có cst là new vô tận object
        //         constructor ném ra ngoại lệ => không new đc object
        //         nếu muốn trong ram chỉ có duy nhất 1 object đc tạo ra, không nhiều hơn 1 vùng ram => singleton (phải hiểu static mới chơi đc)
        //                                                                                              design pattern - mẫu thiết kế class
        //                                                                                              sách của GoF - Gang of Four
        //nó là kiến thức của nghề, vị trí tuyển dụng SA - solution architect - code ra dàn khung của app, chỉ đề xuất các class, interface, để giúp app dễ dàng phát triển, tích hợp và mở rộng
        //website: EDWARD THIÊN HOÀNG (WORDPRESS)
        public Cabinet(int size)
        {
            if (size < 1)
                size = 365;
            _arr = new Student[size];
        }

        //public Student[] Arr
        //{
        //    get { return _arr; } => trả về mảng là trả về luôn cả những phẩn tử null của mảng đó => không đc
        //    set { _arr = value; } => không hợp lý chứ không phải không đc
        //}

        //public int Count
        //{
        //    get { return _count; }
        //    set { _count = value; }
        //}

        //coi như cái tủ đã đóng xong qua việc new cabinet: new Cabinet(500/size) => có mảng gồm size phần tử

        //CRUD
        //add student, mở tủ ra, nhận hồ sơ sinh viên
        //UI: console, web, form,... có ô nhập thông tin, có nút nhấn new Student() đẩy xuống hàm
        //todo: check mảng có full chưa
        public void AddStudent(Student s)
        {
            _arr[_count] = s;
            _count++;
        }

        public void AddStudent(string id, string name, int yob, double gpa)
        {
            _arr[_count++] = new Student()
            { 
                Id = id,
                Name = name,
                Yob = yob,
                Gpa = gpa
            };
        }

        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        //hàm xóa và sửa
        //xóa theo vị trí i và xóa theo id là khác
        //mảng có nhược điểm, kích thước đã fixed khi tạo
        //vậy làm sao để xóa: xóa là lừa đảo, là dồn chỗ lên
        //giảm count nhưng kích thước vẫn như cũ
        //vị trí  [0]   [1]     [2]     [3]     [4]
        //         5     10      15      20      25
        //muốn xóa 15 => dồn 20 lên vị trí 15, dồn 25 lên vị trí 20
        //=> [2] = [3]
        //   [3] = [4]

        public void DeleteStudent(string id)
        {
            int? pos = SearchStudentById(id);

            if (pos.HasValue)    
            {
                for (global::System.Int32 i = (int)pos; i < _count; i++)
                    _arr[i] = _arr[i + 1];
                _arr[_count-1] = null;
                _count--;
            }
        }


        //update theo id và chỉ sửa name, yob, gpa
        //có id => tìm ra vị trí muốn sửa
        public void UpdateStudent(string id, string? newName,  int? newYob, double? newGpa)
        {
            //đi tìm vị trí
            int? pos = SearchStudentById(id);

            if(pos.HasValue)    //~ if(pos != null)
            {
                //todo: thêm câu if để check nếu ta đưa và null của name, yob, gpa thì ta giữ nguyên không đổi, khác null mới đổi
                if(newName != null) _arr[(int)pos].Name = newName;
                if(newYob != null) _arr[(int)pos].Yob = (int)newYob;
                if(newGpa != null) _arr[(int)pos].Gpa = (double)newGpa;
            }
        }

        //phát sinh hàm tìm một vị trí theo id
        //chuỗi String/string trong JAVA và C# đều là biến object
        //biến chuỗi trỏ vùng new String s1 = "Hello"; String s2 = "hello";
        //thì s1 chắc chắn khác s2 do 2 con trỏ trỏ vào 2 vùng new khác nhau
        //trong java, không bao giờ dùng == để so sánh 2 chuỗi
        //trong c# cho phép so sánh dùng == do nó đã override lại dấu == của số cho biến object
        //tuy nhiên java, c#, c đều phân biệt hoa thường, chữ hoa và chữ thường do mã ASCII khác nhau
        public int? SearchStudentById(string id)
        {
            //quét mảng từ đầu đến count coi mỗi đứa [i].Id có bằng id đang tìm không, nếu có trả về vị trí, nếu không trả về null
            if (_count == 0)
                return null;

            for (int i = 0; i < _count; i++)
                if( _arr[i].Id.ToLower() == id.ToLower())
                    return i;

            return null;
        }
    }
}

//btvn: code trên máy xong viết ra giấy, nộp bài: 14/10/2024
//1. hoàn tất nốt hàm xóa 1 phần tử của mảng(dờ chỗ trỏ [1])

//2. hoàn tất nốt hàm update 1 phần tử của mảng(if nốt)

