using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV5.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        //kỹ thuật code kiểu này là kĩ thuật dấu backing field đi
        //runtime tự sinh ra backing field tương ứng với mỗi property để dev đỡ phải gõ những đoạn code nhàm chán nhiều
        //kỹ thuật này gọi là: auto-generated property

        //đôi khi quên cú pháp thì:
        //prop tab và đổi lại cho phù hợp
    }
}
//khi nào xài kỹ thuật property: full property(backing field chủ động), auto-generated property(giấu backing field)
//thông thường xài với class mà nó sẽ map xuống table vì table là nơi Get Set data, xử lý sẽ ở chỗ khác
//không ai cấm dùng property ở các class khác
