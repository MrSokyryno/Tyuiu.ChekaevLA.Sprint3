using Tyuiu.ChekaevLA.Sprint3.Task3.V17.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(98, dataService.ConvertStringToInt("*vn98n! b,"));
        }
    }
}
