using Tyuiu.SobjaninMI.Sprint3.Task4.V8.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double result = ds.Calculate(start, end);
            Assert.AreEqual(2237.227, result);
        }
    }
}
