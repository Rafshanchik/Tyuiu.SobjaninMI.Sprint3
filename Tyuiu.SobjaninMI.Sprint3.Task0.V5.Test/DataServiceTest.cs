using Tyuiu.SobjaninMI.Sprint3.Task0.V5.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 10;
            double res = ds.GetSumSeries(x, y);
            Assert.AreEqual(81.083, res);
        }
    }
}
