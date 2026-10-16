using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SobjaninMI.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double end = stopValue;
            double y = 1;
            for (double x = startValue; x <= end; x++)
            {
                if (x == 0)
                {
                    break;
                }
                y *= ((x / Math.Sin(x)) + 0.5);
            }
            return Math.Round(y, 3);
        }
    }
}
