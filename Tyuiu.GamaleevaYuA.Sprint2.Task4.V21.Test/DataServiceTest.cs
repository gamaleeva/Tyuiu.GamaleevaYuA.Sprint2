using Tyuiu.GamaleevaYuA.Sprint2.Task4.V21.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double wait = 256;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.726;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
