using Tyuiu.SobjaninMI.Sprint3.Task6.V1.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            int start = 11;
            int end = 17;
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(start, end);
            Assert.AreEqual(151, result);
        }
    }
}
