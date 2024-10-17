using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entities
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public override string? ToString() => $"{Id} {Name} {Yob} {Salary}";
    }
}
//ta lại cần 1 tủ đụng hồ sơ giảng viên
//mỗi class giải quyết câu chuyên riêng của nó - SOLID - S: single responsibility
//=> class lecturercabinet xuất hiện, code y chang
