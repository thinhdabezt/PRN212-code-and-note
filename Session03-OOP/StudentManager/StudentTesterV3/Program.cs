using StudentTesterV3.Entities;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student("SE1", "An Hoàng", 2004, 8.6);
            Student an1 = new Student();   //constructor rỗng
            Student an2 = new();           //constructor rỗng + ăn bớt bên phải
            Student an3 = new("SE1", "An Hoàng", 2004, 8.6);
            var an4 = new Student();       //type inference

            Console.WriteLine("An full info: " + an);
            Console.WriteLine("An's name: " + an.Name);

            var binh = new Student(yob: 2004, gpa: 8.7, name: "Bình Nguyễn", id: "SE2");
            //                     name argument

            Console.WriteLine($"Binh full info: {binh}");

            //sử dụng Get Set ngay khi new
            var cuong = new Student();
            Console.WriteLine("Cuong's info at first: {0}", cuong);
            //điền info qua Set() kiểu mlem
            cuong.Id = "SE3";
            cuong.Name = "Cường Võ";
            cuong.Yob = 2004;
            cuong.Gpa = 8.8;
            //Get Set tự nhiên như đang xài biến
            Console.WriteLine($"Cuong's full info after setting(): {cuong}");

            //new và set viết gộp
            var dung = new Student()
            { Id = "SE4", Name = "Dũng Phạm", Yob = 2006, Gpa = 8.9};
            var dung1 = new Student()
            {
                Id = "SE4",
                Name = "Dũng Phạm",
                Yob = 2006,
                Gpa = 8.9
            };//new và set gọi cùng lúc
              //viết cùng hàng hay khác hàng đều ok
              //cú pháp này gọi là: object initialization
              //tạo object đồng thời gán luôn các backing field
            Console.WriteLine($"Dung full info: {dung}");
        }
    }
}
