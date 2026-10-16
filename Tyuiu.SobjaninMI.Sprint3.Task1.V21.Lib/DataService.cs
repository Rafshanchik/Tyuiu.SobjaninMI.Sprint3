using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SobjaninMI.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double k = startValue;
            double res = 1;
            while (k < stopValue + 1)
            {
                res *= Math.Pow(((0.5 + (k / 5)) / (Math.Cos(value) + 0.5)), 3);
                k++;
            }
            return Math.Round(res, 2);
        }
    }
}
//16947810.88