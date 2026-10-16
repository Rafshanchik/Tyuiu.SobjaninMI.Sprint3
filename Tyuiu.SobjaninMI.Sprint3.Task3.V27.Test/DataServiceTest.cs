using System.Reflection;
using Tyuiu.SobjaninMI.Sprint3.Task3.V27.Lib;
namespace Tyuiu.SobjaninMI.Sprint3.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToIn()
        {
            DataService ds = new DataService();
            string str = "!bt, g567kid f!";
            int result = ds.ConvertStringToInt(str);
            Assert.AreEqual(567, result);
        }
    }
}
