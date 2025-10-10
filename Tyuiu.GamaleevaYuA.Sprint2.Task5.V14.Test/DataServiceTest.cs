using Tyuiu.GamaleevaYuA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.FindDayName(1, 1), "Понедельник");
            Assert.AreEqual(ds.FindDayName(1, 2), "Вторник");
            Assert.AreEqual(ds.FindDayName(3, 1), "Среда");
            Assert.AreEqual(ds.FindDayName(11, 1), "Четверг");
            Assert.AreEqual(ds.FindDayName(12, 1), "Пятница");
            Assert.AreEqual(ds.FindDayName(6, 1), "Суббота");
            Assert.AreEqual(ds.FindDayName(7, 1), "Воскресенье");
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, 0);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(368, 9);
            });


        }
    }
}
