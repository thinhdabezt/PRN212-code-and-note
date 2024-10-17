using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV4.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student() { }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public string Id
        {
            get => _id; 
            set => _id = value;
        }
        //lỡ quên cách viết
        //propfull tab tab
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        //=> Get/Set kiểu mới dù dùng tự nhiên theo style của biến nhưng vẫn là boiler plate do lặp lại thứ đã quen

        //=> rút gọn tiếp Get Set
    }
}
