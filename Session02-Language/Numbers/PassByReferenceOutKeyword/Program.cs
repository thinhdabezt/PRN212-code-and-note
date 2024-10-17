namespace PassByReferenceOutKeyword
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int x = 2204;
        //    PlayWithOut(out x);
        //    Console.WriteLine($"x = {x}");

        //    int y;
        //    PlayWithOut(out y);
        //    Console.WriteLine($"y = {y}");

        //    //ChatGPT hay xài
        //    PlayWithOut(out int z); //inline style: khai báo biến ngay trong lúc gọi hàm out, nhưng không biến mất sau khi hàm kết thúc
        //    Console.WriteLine($"z = {z}");
        //}

        static void Main(string[] args) //svm + tab
        {
            //                                      inline declaration
            int sumAll = SumIntegerListV2(out int sumOdds, out int sumEvens);
            Console.WriteLine($"Sum all: {sumAll}");
            Console.WriteLine($"Sum odds: {sumOdds}");
            Console.WriteLine($"Sum evens: {sumEvens}");
        }

        static int SumIntegerListV2(out int sumOdds, out int sumEvens)
        {
            int sumA = 0;
            sumOdds = 0;
            sumEvens = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumA += i;
                if (i % 2 == 0)
                    sumEvens += i;
                else
                    sumOdds += i;
            }

            return sumA;
        }

        //out ~ return
        //hàm co từ khóa out ở tham số sẽ biến hàm này thành hàm có return
        //em hứa sẽ có 1 giá trị của n đc tạo ra ở trong này, em hứa sẽ return n
        //trong hàm mà sửa, bên ngoài sửa ngay
        //khi chơi hàm out, không cần gán giá trị cho biến đầu vào vì nó sẽ bị hàm đè lên giá trị mới, do out hứa sẽ có giá trị trả về
        //hàm mà có out thì biến trong hàm chính là con trỏ trỏ đến biến ngoài hàm, khi gọi out chính là đưa địa chỉ của biến ngoài hàm cho hàm out sửa - PASS BY REFERENCE
        //PASS BY REFERENCE xảy ra với:
        //-biến object, vd: Student s; Lecturer l, Dog chiHuHu; - truyền thống xưa nay

        //-biến primitive/value-type: int, long, float, boolean, char,... đi kèm từ khóa out và ref

        //khi nào thì dùng out
        //CHALLENGE: viết hàm trả về tổng của các số từ 1...10
        //trả về tổng các số chẵn, tổng các số lẻ, trả về có bao nhiêu số nguyên tố
        //chỉ viết một hàm
        static int SumIntegerList(out int sumOdds, out int sumEvens)
        {
            int sumA = 0;
            var sumO = 0;
            var sumE = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumA += i;
                if(i % 2 == 0)
                    sumE += i;
                else
                    sumO += i;
            }

            sumOdds = sumO;
            sumEvens = sumE;

            return sumA;
        }

        static void PlayWithOut(out int n)
        {
            n = 6789; //sbtc, hứa trả về qua ngả parameter
        }
    }
}
