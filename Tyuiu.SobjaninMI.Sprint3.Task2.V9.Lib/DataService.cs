using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SobjaninMI.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int k = startValue;
            double res = 0;
            do
            {
                res += Math.Pow((1 / Math.Pow(value, k)), 2);
                k++;
            } while (k < 11);
            return Math.Round(res, 3);
        }
    }
}
