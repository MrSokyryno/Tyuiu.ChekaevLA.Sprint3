using Tyuiu.ChekaevLA.Sprint3.Task1.V19.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(68.42882992408474, dataService.GetMultiplySeries(1,1,10));
        }
    }
}
