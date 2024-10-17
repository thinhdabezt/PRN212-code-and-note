namespace Poems
    //Mỗi tập tin source code sẽ phải thuộc về 1 thư mục nào đó - gọi là nguồn góc xuất thân hay là ở căn phòng nào. Căn phòng này, thư mục đang ở đc gọi là package(Java), còn C# đc gọi là namespace - không gian đặt tên, nơi chứa các class/tập tin source code

    //~package java.util;
    //~package poems;

    //Tại sao cần có package,namespace: giúp cho việc quản lí nhiều tập tin source code tốt hơn. Chia source code về các thư mục theo nhóm chức năng
    //Giúp trong 1 project có nhiều source code, nhiều class, có quyền trùng tên nhau, miễn là khác thư mục, khác namespace
    //Namespace chỉ chứa class, tập tin
{
    internal class Program
    {
        //Trong class chỉ đc viết
        ///field/atribute/property và method
        //static and non-static
        //instance variable & class variable & method
        static void Main(string[] args)
        {
            PrintSongXuanQuynhV6();
            //Console.ReadLine();
        }

        static void PrintSongXuanQuynhV6()
        {
            int year = 1967;//biến khai báo trong hàm đc gọi là local

            Console.WriteLine("SO'NG " + year);//ghép chuỗi dùng +
            Console.WriteLine("SO'NG " + year + " " + (2024 - year) + " na(m");

            Console.WriteLine("SO'NG {0} {1} na(m", year, (2024 - year));
            //kĩ thuật điền vào chỗ trống - placeholder
            //{0} {1} ... các biến bắt đầu đếm từ 0
            
            Console.WriteLine($"SO'NG {year} {2024-year} na(m");
            //INTERPOLAION: phép nội suy, nhìn sâu vào chuỗi coi có chỗ nào là biến không, nếu có thì thay thế điền vào

            Console.WriteLine(@$"SO'NG {year} {2024-year} na(m
Sóng bắt đầu từ gió
Gió bắt đầu từ đâu
Em cũng không biết nữa
Khi nào ta yêu nhau");
        }

        //CHALLENGE #2: in ra đường dẫn sau
        //C:\Program Files\dotnet
        //C:\news\showbiz
        static void PrintPath()
        {
            Console.WriteLine("C:\\Program Files\\dotnet");
            Console.WriteLine(@"C:\Program Files\dotnet");
            Console.WriteLine(@"C:\news\showbiz");
        }

        //có câu: static chỉ chơi với static
        //CHALLENGE #1: In ra bài thơ Sóng của XQ

        static void PrintSongXuanQuynhV5()
        {
            //có @ đứng trước 1 chuỗi thì sẽ phế võ công tất cả các ký tự đặc biệt trong chuỗi trở lại ký tự bình thường
            //\n thì sẽ in ra \n thay vì xuống hàng
            //@ sẽ biến chuỗi thành có sao in vậy - what you see is what you get
            //@ gọi là kỹ thuật chuỗi nguyên bản - raw string
            //@ còn gọi là verbatim string
            //có bên java

            //khi nào dùng verbatim
            //1. phế võ công ký tự đặc biệt trong chuỗi
            //2. dùng để lưu tên của đường dẫn tập tin, thư mục, chuỗi kết nối CSDL do tên server hay kèm theo ký tự đặc biệt -> ta trả về chuỗi nguyên bản thì chuỗi không bị hiểu sai
            Console.WriteLine(@"Sóng bắt đầu từ gió

<html>
  <head>
    <title>Xin chào</title>
  </head>
  <body>
  </body>
</html>
            Gió bắt đầu từ đâu?
            Em cũng không biết nữa
            Khi nào ta yêu nhau

            Con sóng dưới lòng sâu
            Con sóng trên mặt nước
            Ôi con sóng nhớ bờ
            Ngày đêm không ngủ được
            Lòng em nhớ đến anh
            Cả trong mơ còn thức

            Dẫu xuôi về phương bắc
            Dẫu ngược về phương nam
            Nơi nào em cũng nghĩ
            Hướng về anh - một phương");
        }

        static void PrintSongXuanQuynhV4()
        {
            Console.WriteLine("Sóng bắt đầu từ gió\r\nGió bắt đầu từ đâu?\r\nEm cũng không biết nữa\r\nKhi nào ta yêu nhau\r\n\r\nCon sóng dưới lòng sâu\r\nCon sóng trên mặt nước\r\nÔi con sóng nhớ bờ\r\nNgày đêm không ngủ được\r\nLòng em nhớ đến anh\r\nCả trong mơ còn thức\r\n\r\nDẫu xuôi về phương bắc\r\nDẫu ngược về phương nam\r\nNơi nào em cũng nghĩ\r\nHướng về anh - một phương");
        }

        static void PrintSongXuanQuynhV3()
        {
            Console.WriteLine("" +
                "Sóng bắt đầu từ gió\n" +
                "Gió bắt đầu từ đâu\n" +
                "Em cũng không biết nữa\n" +
                "Khi nào ta yêu nhau");
            // dấu + đc gọi là toán tử ghép chuỗi - operation để nối chuỗi - string concatenation
        }

        static void PrintSongXuanQuynhV2()
        {
            Console.WriteLine("Sóng bắt đầu từ gió\nGió bắt đầu từ đâu\nEm cũng không biết nữa\nKhi nào ta yêu nhau");
            // \n mỗi khi xuất hiện trong chuỗi "" thì sẽ đc hiểu là không phải in \n mà là in xuống hàng - kí tự đặc biệt
            //ký tự \ đi kèm với \n \e \t \a mang 1 ý nghĩa nào đó mà bị biến dạng rồi
        }

        static void PrintSongXuanQuynh()
        {
            Console.WriteLine("Sóng bắt đầu từ gió");//gõ cw + bấm tab ~ sout(Java)
            Console.WriteLine("Gió bắt đầu từ đâu");
            Console.WriteLine("Em cũng không biết nữa");
            Console.WriteLine("Khi nào ta yêu nhau");
        }
    }
}
