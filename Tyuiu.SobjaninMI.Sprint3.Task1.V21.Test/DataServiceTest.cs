using Tyuiu.SobjaninMI.Sprint3.Task1.V21.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            int x = 1;
            int k = 1;
            int y = 12;
            DataService ds = new DataService();
            double result = ds.GetMultiplySeries(x, k, y);
            Assert.AreEqual(0.799, result);
        }
    }
}
