using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SobjaninMI.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    res += c;
                }
            }
            return Convert.ToInt32(res);
        }
    }
}
