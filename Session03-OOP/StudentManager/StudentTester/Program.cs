using StudentTester.Entities;
//~ .* bên java

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentObject();
        }

        static void CreateStudentObject()
        {
            Student an = new Student("SE1", "An Hoàng", 2004, 8.6);
            //gọi cái phễu(contructor) để đổ vật liệu vào bên trong cái khuôn(class) để đúc 1 object

            Student binh = new("SE2", "Bình Nguyễn", 2004, 8.7);
            //new kiểu mới, không cần data type vì bên trái đã có rồi

            //var cuong = new("SE3", "Cường Võ", 2004, 8.8);
            //   nickname            object
            //con người có xu hướng đặt tên gọi cho mọi thứ (đơn giản & phức tạp)
            //hai bên đều không rõ ràng về data type
            var cuong = new Student("SE3", "Cường Võ", 2004, 8.8);

            //Student dung = new(8.9, 2006, "SE200001", "Dũng Phạm");
            //khi gọi tham số hàm, phải gọi đúng thứ tự biến đã đc xác định ở tên hàm
            //contructor là 1 hàm đặc biệt để clone vùng ram và fill info của object
            Student dung = new Student(gpa: 8.9, yob: 2006,id: "SE200001",name: "Dũng Phạm");
            //kĩ thuật gọi hàm không theo ký tự biến miễn là chỉ ra được biến nào ứng với value nào qua ký hiệu: tên biến: value
            //linh hoạt trong cách gọi hàm
            //kỹ thuật này gọi là: NAMED-ARGUMENT
            //gọi hàm kèm tên tham số

            an.FlexProfile();
            binh.FlexProfile();
            cuong.FlexProfile();
            dung.FlexProfile();

            Console.WriteLine();

            Console.WriteLine($"An's name: " + an.GetName());
            Console.WriteLine($"Bình's name: {0}", binh.GetName());
            Console.WriteLine($"Cường's name: {cuong.GetName()}");
            Console.WriteLine($"Dũng's name: {dung.GetName()}");

            Console.WriteLine();

            //điểm trung bình đc cập nhật
            an.SetGpa(6.8);    
            an.FlexProfile();//expected: 6.8
            binh.FlexProfile();//8.7
            cuong.FlexProfile();//8.8
            dung.FlexProfile();//8.9

            Console.WriteLine();

            Student s = an; //2 chàng 1 nàng

            s.FlexProfile();

            Console.WriteLine();

            s.SetGpa(8.6);

            an.FlexProfile();

            Console.WriteLine();

            s = binh;

            s.FlexProfile();

            Console.WriteLine();

            Student xxx = an;
            an = binh;
            Console.WriteLine("3 chàng 1 nàng");
            an.FlexProfile();
            xxx.FlexProfile();

            // System.GC. : Garbage Collector, module trong runtime
            //chuyên dọn dẹp vùng mồ côi trong ram, không có biến trỏ đến
        }
    }
}
