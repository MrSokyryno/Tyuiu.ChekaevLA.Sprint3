using Tyuiu.ChekaevLA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(-35.317, dataService.Calculate(-5, 5));
        }
    }
}
