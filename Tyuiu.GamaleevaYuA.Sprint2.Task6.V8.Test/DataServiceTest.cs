using Tyuiu.GamaleevaYuA.Sprint2.Task6.V8.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            string wait = "28 декабря";
            int m = 12;
            int n = 29;
            string res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
            
        }
    }
}
