using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)//svm + tab
        {
            Console.WriteLine($"BMI: {BmiCalculator.GetBmi(70, 1.7)}");
        }

        //trong class chứa: fields/ attributes/ và methods => gọi chung là: members of a class
        //fields/ attributes: có 2 dạng, method cũng vậy
        //static                   non-static
        //class-level variable     instance variable
        //static void Main(string[] args)
        //{
        //    //PrintBmiV2(70, 1.7);
        //    double bmi = GetBmi(70, 1.7);
        //    Console.WriteLine("BMI: "+bmi);
        //    Console.WriteLine("BMI: {0}", bmi);
        //    Console.WriteLine($"BMI: {bmi}");
        //    Console.WriteLine("BMI: " + GetBmi(70, 1.7));
        //    Console.WriteLine($"BMI: {GetBmi(70, 1.7)}");
        //}
        //CHALLENGE #1: VIẾT HÀM TÍNH VÀ IN RA CHỈ SỐ BMI - BODY MASS INDEX - CHỈ SOSOS KHỐI CƠ THỂ CỦA AI ĐÓ THEO CHIỀU CAO VÀ CÂN NẶNG
        //BMI = WEIGHT(kg) / (HEIGHT(M))^2
        //BMI[18.5...24.5] => ỔN
        //Triết lý thiết kế hàm: hàm thiết kế tốt thì hàm đó nên thuộc style hàm nhận đầu vào và trả ra kết quả. Hàm không nên có lệnh nhập và in trong code hàm
        //Lý do: thiết kế hàm nhận vào trả ra sẽ giúp hàm linh hoạt hơn trong cách nó đc sử dụng, hàm sẽ đc sử dụng trong các biểu thức khác
        //Tăng tính sử dụng lại - reuse mức cao

        //VD: lúc viết hàm kiểm tra xem n có là số nguyên tố không
        //for(int i = 2, i < n, i++)
        //giang hồ chứng minh chỉ cần for đến căn bậc 2
        //for(int i = 2, i <= Math.Sqrt(n), i++)

        //Kĩ thuật cái dây nịt
        //            GetBmi: tên hàm - SIGNATURE OF A METHOD
        //            {...}: code của hàm - BODY OF A METHOD
        //            {...}: thân hàm, IMPLEMENT OF A METHOD
        //Nếu hàm chỉ có duy nhất 1 lệnh, ta có thể áp dụng quy tắc rút gọn để hàm chỉ còn cái dây nịt ở mức tối thiểu
        //Ta dẹp bỏ {, return, } chỉ còn lại cái tên hàm nối với thân hàm qua =>
        //Kỹ thuật rút gọn hàm chỉ có 1 lệnh đc gọi là EXPRESSION BODIED, EXPRESSION BODY
        //Thân hàm viết giống như biểu thức
        //Cấm tuyệt đối không đc nhầm lẫn với => với 1 khái niệm khác biểu thức lamda - lamda expression, cũng xài chung ký hiệu =>

        static double GetBmiV2(double weight, double height) => weight / Math.Pow(height, 2);

        static double GetBmi(double weight, double height)
        {
            //double bmi = weight / Math.Pow(height, 2);
            //return bmi;
            return weight / Math.Pow(height, 2);
        }

        static void PrintBmiV3(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine("BMI (w: {0}; h: {1}) = {2}", weight, height, bmi);
            Console.WriteLine($"BMI (w: {weight}; h: {height}) = {bmi}");
        }

        static void PrintBmiV2(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine("BMI (w: {0}; h: {1}) = {2}", weight, height, bmi);
            Console.WriteLine($"BMI (w: {weight}; h: {height}) = {bmi}");
        }

        static void PrintBmi(double weight, double height)
        {
            double bmi = weight / (height * height);
            Console.WriteLine("BMI (w: {0}; h: {1}) = {2}", weight, height, bmi);
            Console.WriteLine($"BMI (w: {weight}; h: {height}) = {bmi}");
        }
    }
}
