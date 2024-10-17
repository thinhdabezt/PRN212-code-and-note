using PrimitiveList.Entities;
using System.Collections;
using System.Threading.Channels;

namespace PrimitiveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithPrimitiveListV2();
            PlayWithStudentlist();
        }

        static void PlayWithStudentlist()
        {
            List<Student> arr = new List<Student>();

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
            arr.Add(new Student()
            {
                Id = "SE3",
                Name = "Cuong Vo",
                Yob = 2004,
                Gpa = 8.8
            });

            Console.WriteLine("The list of the student(s)");
            foreach (var item in arr)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void PlayWithPrimitiveListV2()
        {
            List<int> arr = new List<int>();
            //arr chỉ chứa đc int, cấm đưa lộn xộn
            arr.Add(1);
            arr.Add(10);
            arr.Add(-500);
            //arr.Add("Hello"); chửi vì không cùng data type

            //print
            Console.WriteLine($"arr's size is: {arr.Count}"); //3 biến, nhưng có thể mở rộng thêm
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The list printed by for i");
            for (int i = 0; i < arr.Count; i++)
            {
                //Console.WriteLine(arr[i]);//hay dùng, xài như mảng

                Console.WriteLine(arr.ElementAt(i));
            }
        }

        static void PlayWithPrimitiveList()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(10);
            arr.Add("Hello");
            arr.Add("3.14");
            arr.Add(true);
            arr.Add(new Student() { });

            Console.WriteLine($"There is/are {arr.Count} item(s)");
            //for each, for count đến cuối mảng thẳng tiến - vì không cấp dư
            //ngay cả xóa cũng là xóa thật

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //for i bình thường như mảng

            Console.WriteLine("The list printed by for i");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]); //get phần tử thứ i như mảng
            }

            //ArrayList<Student> arr = new ArrayList();
            //arraylist không hỗ trợ generic bên java
        }
    }
}
//để lưu đc nhiều dữ liệu nói chung (primitive, object) trong ram ta dùng nhóm class thay cho mảng để fix những hạn chế của mảng
//những class này khi nó đc new thì bên trong vùng new này sẽ dự định chứa nhiều biến nhỏ hơn - y chang vùng new mảng sẽ chứa nhiều biến bên trong
//khác mảng: vùng nhớ này co giãn, chứa nhiều thì nở ra, chứa ít thì hẹp lại, xóa thì mất luôn các xóa
//toàn bộ các nhóm class này gọi là chung là collections
//chúng sẽ gồm nhiều interfacec, nhiều abstract class       nhiều class cụ thể
//                   --------------------------------       ------------------
//                   không new đc vì chứa hàm không code    new đc, concrete class

//java:
//abstract class, interface: List,              Set,                Map(không new)
//concrete class, new đc:  ArrayList        HashSet,TreeSet       HashMap, TreeMap
//                        vào thứ tự nào  ngẫu nhiên|có thứ tự
//                        ra thứ tự đấy
//khai báo: List<Student> arr = new List<Student>();    //vỡ mặt vì sinh ra 20 hàm không code, yêu cầu code nốt/implement -> annonymous class -> cấm
//khai cha new con
//List<Student> arr = new ArrayList<Student>();
//khai con new con chuyện quá bình thường
//ArrayList<Student> arr = new ArrayList<Student>();

//c#:
//ArrayList không có bà con gì với List hết
//ArrayList chứa bên trong cái gì cũng đc và new đc, concrete class
//nhưng nó không generic thoải mái add data nào vào cũng đc

//list cũng concrete, new đc và xài generic
//tức là chỉ add 1 loại data type, y chang Cabinet đã viết

//khuyên dùng, dùng List, không dùng ArrayList vì không ép đc kiểu datatype đưa vào