using Tyuiu.SobjaninMI.Sprint3.Task7.V4.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;

            int len = end - start + 1;

            double[] value;
            value = new double[len];

            value[0] = -2.15;
            value[1] = -2.57;
            value[2] = -3.00;
            value[3] = -3.83;
            value[4] = -11.70;
            value[5] = 3.00;
            value[6] = 2.19;
            value[7] = 3.31;
            value[8] = 2.97;
            value[9] = 1.18;
            value[10] = 0.03;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(value, res);
        }
    }
}
