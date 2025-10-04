using Tyuiu.GamaleevaYuA.Sprint2.Task0.V29.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            bool[] wait = new bool[] { false, false, true, true, false, false };
            int x = 105;
            int y = 735;
            bool[] res = new bool[6]; 
            res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
