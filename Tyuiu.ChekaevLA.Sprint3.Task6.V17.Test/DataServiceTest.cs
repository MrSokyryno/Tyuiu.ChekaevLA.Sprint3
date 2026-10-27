using Tyuiu.ChekaevLA.Sprint3.Task6.V17.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            Assert.AreEqual(43, service.GetSumTheDivisors(10,20));
        }
    }
}
