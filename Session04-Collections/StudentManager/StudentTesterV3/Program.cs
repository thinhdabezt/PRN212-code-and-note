using StudentTester.Entities;
using StudentTesterV3.Services;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hiểu thêm về mảng, biến tham chiếu, biến con trỏ
            int[] a =  { 1, 2, 3, 4, 5};                //5 biến int
            int[] b =  { 5, 10, 15, 20 ,25, 30, 35, 40};//8 biến int

            Console.WriteLine("a[0] before connecting to b: " + a[0]);
            Console.WriteLine("a's size before connecting to b: " + a.Length);

            a = b;//2 chàng 1 nàng, mảng cũ của a bị mồ côi, sẽ bị bộ dọn dẹp của runtime dọn

            Console.WriteLine("a[0] after connecting to b: " + a[0]);
            Console.WriteLine("a's size after connecting to b: " + a.Length);

            //tên mảng là tên tham chiếu trỏ vung new
            //một lần nữa 2 biến object = nhau nghĩa là trỏ trùng
            //nếu tên mảng, tên biến object đưa qua tham số hàm, chẳng qua cũng là 2 chàng 1 nàng
            //hàm search trả về object -> không phải, trỏ vào vùng new tìm thấy
            //mảng đã xin thì không thay đổi kích thước đc, muốn thay đổi trỏ mảng mới với kích trước mới

            a = new int[5000];
            //a trỏ tới mảng mới 5000 biến int
            //hạn chế của mảng: fix kích thước, muốn đổi kích thước phải trỏ mảng khác, phải đi kèm biến count, phá count là phá mảng

            //collections giải quyết các hạn chế này
            //java:
            //c#:
            //collections trong java và c# có điểm giống và khác đều là những class giống như class cabinet đã viết, tức là đc sinh ra những class này để chứa nhiều object hơn nhưng linh hoạt hơn mảng, co giãn về kích thước, muốn thêm mới thì nới, muốn xóa thì thu hẹp
            //99% các class này đc thiết kế để chứa nhiều object vậy nên nó phải loose coupling, tức là generic
            //muốn xài nó thì phải nói rằng chứa object gì
        }

        static void PlayWithGeneric()
        {
            //mua tủ đựng hồ sơ sinh viên, hồ sơ giảng viên, mỗi nhóm 1 tủ khác nhau
            Cabinet<Student> arr = new Cabinet<Student>(500);
            Cabinet<Lecturer> tuGV = new Cabinet<Lecturer>(500);

            //      Student item
            arr.Add(new Student()
            {
                Id = "SE1",
                Name = "An Hoang",
                Yob = 2004,
                Gpa = 8.6
            });
            arr.Add(new Student()
            {
                Id = "SE2",
                Name = "Binh Nguyen",
                Yob = 2004,
                Gpa = 8.7
            });
            //hậu trường: _arr[_count] = new Student() ở trên

            var s = new Student()
            {
                Id = "SE3",
                Name = "Cuong Vo",
                Yob = 2004,
                Gpa = 8.8
            };
            arr.Add(s);
            //hậu trường _arr[_count] = s = new Student() đã new bên ngoài
            //biến object này = biến object kia nghĩa là truyền thái y style tham chiếu, 2 chàng 1 nàng
            //hàm nhận vào (Student item) = s bên ngoài

            arr.Print();
        }
    }
}
