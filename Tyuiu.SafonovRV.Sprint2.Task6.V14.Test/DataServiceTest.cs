using Tyuiu.SafonovRV.Sprint2.Task6.V14.Lib;

namespace Tyuiu.SafonovRV.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();


            Assert.AreEqual("Воскресенье", ds.FindDayName(2, 6));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, 366);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, 8);
            });
        }
    }
}