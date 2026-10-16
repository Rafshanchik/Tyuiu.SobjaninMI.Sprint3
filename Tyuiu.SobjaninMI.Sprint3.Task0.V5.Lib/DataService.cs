using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SobjaninMI.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            for (int k = startValue; k < stopValue + 1; k++)
            {
                sum += (Math.Pow(1 / Math.Sin(k), 2));
            }
            return Math.Round(sum, 3);
        }
    }
}
