using Tyuiu.ChekaevLA.Sprint3.Task5.V16.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(115.748, dataService.GetSumSumSeries(2,1,1,3,10));
        }
    }
}
