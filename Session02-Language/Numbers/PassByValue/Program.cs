namespace PassByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            PowerByTwo(n);
            Console.WriteLine($"In Main, after calling mehotd, n now is {n}");
        }

        static void PowerByTwoV2(in int n) //in mang ý nghĩa làm cho biến đầu vào làm cho biến readonly, cấm sửa giá trị đầu vào, chỉ được sử dụng

        //CHALLENGE Ở NHÀ: ĐIỀU GÌ XẢY RA NẾU THAM SỐ ĐẦU VÀO LÀ (in student x), BIẾN ĐẦU VÀO LÀ OBJECT THÌ IN SẼ MANG Ý NGHĨA READ ONLY NHƯ THẾ NÀO
        //in cấm biến = 1 giá trị khác, = 1 giá trị khác tức là thay đổi value
        {
            //n = n * n;            
        }

        //TRUYỀN THÁI Y STYLE THAM TRỊ, GIỐNG C VÀ JAVA - PASS BY VALUE
        //TA DÙNG TRONG TÌNH HUỐNG LÀ DATA TYPE KIỂU
        //PRIMITIVE(JAVA):int, long, float, double,...
        //VALUE-TYPE(C): int, long, float, double,...
        //TRONG HÀM MÀ SỬA, BÊN NGOÀI VẪN GIỮ NGUYÊN
        //CHALlENGE #1: VIẾT HÀM NHẬN VÀO 1 CON SỐ VÀ BÌNH PHƯƠNG NÓ LÊN
        static void PowerByTwo(int n) //hàm nhận vào số nguyên n và trả về bình phương
        {
            Console.WriteLine($"In method, before changing, n is {n}");
            n = n * n; //Math.Power(n, 2);
            Console.WriteLine($"In method, after changing, n now is {n}");
        }
    }
}
