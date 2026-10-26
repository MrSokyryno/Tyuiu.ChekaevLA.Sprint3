using Tyuiu.ChekaevLA.Sprint3.Task2.V1.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(0.3527970928045026, dataService.GetSumSeries(1, 10));
        }
    }
}
