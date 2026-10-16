using Tyuiu.SobjaninMI.Sprint3.Task5.V19.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int i = 1;
            int k = 1;
            int end1 = 3;
            int end2 = 6;
            double result = ds.GetSumSumSeries(x, i, k, end1, end2);    
            Assert.AreEqual(30598.002, result);
        }
    }
}
