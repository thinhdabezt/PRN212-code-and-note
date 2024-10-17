namespace Bmi
{
    /// <summary>
    /// This class offers methods for evaluaing the healthy status based on the weight and height
    /// </summary>
    public class BmiCalculator
    {
        /// <summary>
        /// Returns the BMI indicator of someone
        /// Hàm trả về chỉ số BMI của ai đó
        /// </summary>
        /// <param name="weight">Weight is under kg</param>
        /// <param name="height">Height is under m</param>
        /// <returns></returns>
        public static double GetBmi(double weight, double height) => weight / Math.Pow(height, 2);

    }
}
