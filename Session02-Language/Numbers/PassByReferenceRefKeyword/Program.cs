namespace PassByReferenceRefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 19;
            int x;
            PlayWithOut(out x);
            Console.WriteLine($"x: {x}");

            PlayWithOut(out int y);
            Console.WriteLine($"y: {y}");

            //xài ref
            int z = 0;
            PlayWithRef(ref z); //hàm không hứa trả về nên z phải có value trước để đảm bảo tính logic: gọi hàm thì phải có value để hàm xử lý info
            Console.WriteLine($"z: {z}");
            //PlayWithRef(ref int zzz); không hỗ trợ inline với ref, do inline chỉ mang ý nghĩa khai báo biến không gán value
        }

        //out, ref là 2 keyword sẽ biến tham số đầu vào trở thành con trỏ, pointer, reference bất chấp biến này là primitive hay biến object
        //biến object đã là reference rồi

        static void PlayWithRef(ref int n)
        {
            //trong hàm thay đổi, bên ngoài đổi theo
            //ref: không hứa sẽ có value, nhưng nếu có chắc chắn bị đổi theo
        }

        static void PlayWithOut(out int n)
        {
            //out: hứa chắc kèo sẽ có 1 n đc gán giá trị
            //trong hàm thay đổi, bên ngoài đổi theo
            n = 6789;
        }
    }
}
