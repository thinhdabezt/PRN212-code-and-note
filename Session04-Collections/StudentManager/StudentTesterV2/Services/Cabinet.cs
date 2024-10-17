using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //T: type bất kỳ, ta chưa biết ta sẽ làm việc với data-type nào, data-type cũng là tham số
    //sử dụng: 
    //Cabinet<Student> tuSE = new Cabinet<Student>(); => tủ sinh viên
    //Cabinet<Lecturer> tuGVSE = new Cabinet<Lecturer>();
    public class Cabinet<T>
    {
        //private Lecturer[] _arr;
        //private Student[] _arr;
        private T[] _arr; //T có thể là Lecturer, Student,...
        private int _count;

        public Cabinet(int size)
        {
            //...
            _arr = new T[size];
        }

        public void Add(T item) => _arr[_count++] = item;

        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} profile(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        public void Delete(string id)
        {
            int? pos = SearchById(id);

            if (pos.HasValue)
            {
                for (global::System.Int32 i = (int)pos; i < _count; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                _arr[_count - 1] = _arr[_count];
                _count--;
            }
        }

        public void Update(string id, string? newName, int? newYob, double? newGpa)
        {
            //int? pos = SearchById(id);

            //if (pos.HasValue)
            //{
            //    if (newName != null) _arr[(int)pos].Name = newName;
            //    if (newYob != null) _arr[(int)pos].Yob = (int)newYob;
            //    if (newGpa != null) _arr[(int)pos].Gpa = (double)newGpa;
            //}
        }

        public int? SearchById(string id)
        {
            //if (_count == 0)
            //    return null;

            //for (int i = 0; i < _count; i++)
            //    if (_arr[i].Id.ToLower() == id.ToLower())
            //        return i;

            return null;
        }
    }
}
//3. hoàn tất nốt class này và code main thử nghiệm
