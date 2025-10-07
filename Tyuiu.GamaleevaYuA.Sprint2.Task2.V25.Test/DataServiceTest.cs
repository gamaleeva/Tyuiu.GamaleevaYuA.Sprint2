using Tyuiu.GamaleevaYuA.Sprint2.Task2.V25.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            bool wait = true;
            int x = 6;
            int y = 7;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
