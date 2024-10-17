using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student()
        {

        }

        //ctrl + . => generate constructor
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //get và set
        //Id là 1 thứ lai giữa biến và hàm, bao Get() Set() lại, nhưng xài get set 1 cách bth, qua style gán giá trị cho biến
        //cw(.Id) ~ return _id
        //.Id = value ~ _id = value
        //chơi biến nhưng gọi hàm => tự nhiên trong viết code
        //property of a class
        public string Id
        {
            get
            {
                return _id;  //backing field
            }
            set
            {
                _id = value;
            }
        }
        //.Id sẽ là get value của id
        //.Id = "..." sẽ là set value của id
        //=>Id là lai giữa biến và hàm

        //     GetName() SetName() truyền thống
        public string Name
        {
            get 
            {
                return _name;
            }
            set
            {
                _name = value;
            }
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
        //xài prop nghĩa là ta chế ra 1 biến lai hàm, nó bao bên trong 2 hàm Get Set truyền thống và 2 hàm này thao tác trên _field để lưu trữ và thao tác các field/attribut của 1 class
        //_field lúc này đc gọi là hậu phương của của biến lai
        //đằng sai prop là biến _field lo cho việc Get Set
        //                      _field lúc này đc gọi là backing field

        public override string? ToString() => $"Id: {Id} | Name: {Name} | Yob: {_yob} | Gpa: {_gpa}";
        //xài hàm Get qua prop và xài trực tiếp _field đều ok
    }
}
