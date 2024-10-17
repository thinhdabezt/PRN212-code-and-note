using StudentTester.Entities;
using StudentTesterV2.Services;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet<Student> tuSE = new(500);
            Cabinet tuIA = new(100);

            tuSE.AddStudent("SE1", "An Hoang", 2004, 8.6);
            tuSE.AddStudent("SE2", "Binh Nguyen", 2004, 8.7);
            tuSE.AddStudent(new Student() { Id = "SE3", Name = "Cuong Vo", Yob = 2004, Gpa = 8.8 });

            tuIA.AddStudent("SE4", "Dung Pham", 2004, 8.9);

            //in
            Console.WriteLine("The list of IA students");
            tuSE.PrintStudentList();
            Console.WriteLine("The list of SE students");
            tuIA.PrintStudentList();

            //update
            tuSE.UpdateStudent("SE3", "Negav - Anh trai say goodbye", null, null);

            Console.WriteLine("After updating SE3's name");
            tuSE.PrintStudentList();
        }
    }
}
