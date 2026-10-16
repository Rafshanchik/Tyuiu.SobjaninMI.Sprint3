using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SobjaninMI.Sprint3.Task7.V4.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mas;
            int len = (stopValue - startValue) + 1;
            mas = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + x - 3 == 0)
                {
                    mas[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round(((2 * x + 6) / (Math.Cos(x) + x)) - 3, 2);
                    mas[count] = y;
                    count++;
                }
            }
            return mas;
        }
    }
}
