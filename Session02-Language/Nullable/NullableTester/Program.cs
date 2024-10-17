namespace NullableTester
{
    //trong khuôn viên namespace chỉ chứa các class và những thằng ngang cơ class: interface, delegate

    //có thể khai báo class gộp chung trong 1 tập tin vật lý hoặc tách riêng mỗi class 1 tập tin .cs riêng
    //nhưng dù chung hay riêng thì vẫn phải khai báo hộ khẩu - namespace
    //nha sĩ khuyên dùng: trừ tình huống đặc biệt, thì nên tách mỗi class 1 tập tin .cs cho dễ dàng quản lý source code và khai báo chung namespace
    //1 project có nhiều namespace

    public class Student 
    {   //phá OOP 1 chút, không dùng encapsulation
        public string id;
        public string name;
        public int yob;
        public double gpa;

        //không che dấu thông tin, public là ai cũng thấy

        public void FlexProfile()
        {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Yob: {yob}");
            Console.WriteLine($"GPA: {gpa}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s =         new Student();
            //    biến obj          object: vùng ram chứa info object
            //                  new: xin vùng ram bự ~ malloc() bên C
            //biến: nickname của 1 value
            s.id = "SE1";
            s.name = "AN";
            s.yob = 2004;
            s.gpa = 8.6;

            s.FlexProfile();

            s = null;
            //s.FlexProfile(); //exception
            //biến object = null nghĩa là trỏ vào đáy RAM, không có code ở đó, chấm 1 cái gì đấy, gọi hagm của class sẽ bị Null Reference do đáy ram không có code để chạy
            //dùng null để làm gì
            //1. hủy vùng object đã new, do biến đã trỏ vùng ram khác
            //2. dùng để nói biến đang không trỏ object nào
            //2.1 khi search 1 object trong list, tìm không thấy thì trả về null
            //dùng toán tử is null, == null, != null để check biến có trỏ vào ai hay không
            if (s == null)
                Console.WriteLine("No student is specified. Nothing no print");
            else
                s.FlexProfile(); //no longer exception

            //trong db, có khái niệm null trên cell(hàng cột giao nhau), cột điểm pe, điểm te, null mang ý nghĩa rằng cột/cell đó có value nhưng chưa biết là value gì, từ từ sẽ có
            //có 1 cái gì đó diễn tả trạng thái tạm thời bỏ trống, sau đó sẽ điền vào
            //null là 1 trạng thái, tình trạng của cột dữ liệu chưa có value
            //ánh xạ ngược lên code, làm sao để diễn tả cột điểm chưa xác định trong lập trình

            //double pe = null; //biến primitive - giá trị đơn không có khái niệm null - giá trị phải là con số, cái chữ cái nào đó!!!không diễn tả đc trạng thái em chưa có gì, em chưa xác định
            //java: int -> Integer mang null oke (wrapper class),...

            //C#: dùng toán tử/keyword/kí hiệu ? đi kèm value-type giúp mở rộng, cho phép mang thêm giá trị null
            double? pe = null;//y chang double, chỉ thêm value null. Ta xài is null, == null, != null như truyền thống để kiểm tra
            if(pe == null)
                Console.WriteLine("Chưa có điểm đâu cưng");
            else
                Console.WriteLine($"Điểm nè: {pe}");

            //? gắn với data type value-type sẽ giúp các biến các biến của loại data type mới này đc mang thêm giá trị null, mang ý nghĩa biến chưa xác định value
            //TA CÓ: int? long? float? double? char? bool?
            //đám này đc gọi là nullable data type
            //em có thể mang giá trị null ngoài giá trị truyền thống

            //VẬY Student? s; Lecturer? l; Product? p
            //    Student s; Lecturer l; Product p
            //? không thành vấn đề vì biến object sinh ra đã sẵn đc mang null
            //đôi khi mình cần Student? vì IDE hay warning khi mình gán null
            //hàm seach hay dùng null để nói rằng chưa biết, không tìm thấy
            //value = null để nói rằng thông tin của biến tạm thời chưa xác định
        }
    }
}
