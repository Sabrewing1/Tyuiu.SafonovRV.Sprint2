using Tyuiu.SafonovRV.Sprint2.Task2.V5.Lib;

namespace Tyuiu.SafonovRV.Sprint2.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);

        }
    }
}