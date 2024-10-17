using StudentTesterV2.Entities;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student();
            an.SetId("SE1");
            an.SetName("An Hoang");
            an.SetYob(2004);
            an.SetGpa(8.6);
            //toàn bộ info là default
            //chuỗi -> empty, số -> 0, bool -> false
            an.FlexProfile();
            Console.WriteLine(an.ToString());
            Console.WriteLine(an); //gọi thầm tên em
            //khi bạn quyết định in ra biến object, bên c in ra địa chỉ con trỏ
            //bên java, c# nó đi tìm hàm ToString() để chạy
            //java: in ra mã băm (harsh number) của vùng ram nếu class không có hàm toString()
            //c#: chỉ trả về data type của vùng new chứ không in ra mã băm

            //vậy nếu cố tình sửa lại code ToString() đc không => đc, thì mới gọi là override

            
        }
    }
}
