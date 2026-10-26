using Tyuiu.ChekaevLA.Sprint3.Task0.V17.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(-0.708723873227953, dataService.GetSumSeries(1,10));
        }
    }
}
