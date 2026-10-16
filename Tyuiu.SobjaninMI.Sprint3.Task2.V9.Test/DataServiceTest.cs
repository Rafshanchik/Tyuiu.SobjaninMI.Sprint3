using Tyuiu.SobjaninMI.Sprint3.Task2.V9.Lib;

namespace Tyuiu.SobjaninMI.Sprint3.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            int n = 5;
            int k = 1;
            int x = 10;
            DataService ds = new DataService();
            double result = ds.GetSumSeries(n, k, x);
            Assert.AreEqual(0.042, result);
        }
    }
}
