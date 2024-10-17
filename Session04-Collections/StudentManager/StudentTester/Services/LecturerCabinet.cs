using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _arr;
        private int _count = 0;

        public LecturerCabinet(int size)
        {
            if (size < 1)
                throw new ArgumentOutOfRangeException("Invalid size! Size must be at least 1");
            _arr = new Lecturer[size];
        }

        public void AddLecturer(Lecturer lecturer)
        {
            _arr[_count++] = lecturer;
        }

        public void AddLecturer(string id, string name, int yob, double salary)
        {
            _arr[_count++] = new Lecturer()
            {
                Id = id,
                Name = name,
                Yob = yob,
                Salary = salary
            };
        }

        public int? SearchLecturerById(string id)
        {
            if(_count == 0) return null;

            for (int i = 0; i < _count; i++)
                if (_arr[i].Id.ToLower() == id.ToLower())
                    return i;

            return null;
        }
    }
}
