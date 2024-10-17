using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //một class có vô số contructor: vô số tùy theo bạn muốn fill data ntn: _id only; _id _name (*),...
        //điều gì xảy ra nếu không tạo constructor => runtime sẽ tạo cho bạn 1 contructor default/ empty constructor
        //khi xài constructor default, ta vẫn new đc object nhưng info bỏ trống, default
        //số => 0; chuỗi => empty

        //tuy nhiên, ta có thể chủ động tạo sẵn 1 constructor default(explicit empty constructor - tường minh, rõ ràng)
        //ngầm tạo giúp mình gọi là implicit empty constructor - không tường minh

        //ctor + tab
        public Student() { } //explicit empty constructor

        //tạo constructor empty và các constructor khác
        //crtl + .
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        //có bao nhiêu constructor, có bấy nhiêu cách new class
        //nếu đã có sẵn 1 constructor nào đó, runtime sẽ không chủ động tạo cst default nữa, trừ khi bạn chủ động tạo explicit nó
        //mục tiêu cuối: class cần ít nhất 1 cst để đúc class

        //đúc xong thì có object, ta sẽ xxem Get() sửa Set(), xem tất cả FlexProfile()
        public void FlexProfile() => Console.WriteLine($"ID: {_id} | NAME: {_name} | YOB: {_yob} | GPA: {_gpa}");

        public override string? ToString() => $"ID: {_id} | NAME: {_name} | YOB: {_yob} | GPA: {_gpa}";
            //return base.ToString();

        //Get() và Set(): lấy từng miếng info của object và thay đổi info object
        //lý thuyết: có n fields thì có nx2 hàm Get() Set()
        public string GetId() => _id;
        public string GetName => _name;
        public int GetYob => _yob;
        public double GetGpa => _gpa;
        //mọi hàm Set() luôn cần 1 value đưa vào
        public void SetId(string id) => _id = id;
        public void SetName(string name) => _name = name;
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;

        //Get() Set() viết theo style này rất nhàm chán, quen thuộc nhưng vẫn phải làm vì nó giúp object có tương tác: cung cấp, tiếp nhận info
        //bắt buộc phải làm, lặp đi lặp lại
        //ngta gọi là BOILER PLATE

        //C# giúp bạn 1 style mới, tránh code boiler plate
        //1 biến bất kỳ 
        //int yob =2004;
        //ta muốn get value của nó, tên biến là đủ
        //xài tên biến là Get()
        //cw(yob); //lấy value và in ra

        //ta muốn set value cho biến
        //tên biến = value
        //yob = 2006; set value

        //bản thân 1 biến đã mang 2 ý nghĩa get và set
        //có cần 1 cái hàm để bao hàm 2 hành động này không
    }
}
