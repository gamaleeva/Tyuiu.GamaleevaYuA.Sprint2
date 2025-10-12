using Tyuiu.GamaleevaYuA.Sprint2.Task7.V4.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
            
        }
    }
}
