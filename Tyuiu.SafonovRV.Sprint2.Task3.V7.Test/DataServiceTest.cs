using Tyuiu.SafonovRV.Sprint2.Task3.V7.Lib;

namespace Tyuiu.SafonovRV.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1() 
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.564;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = - 4 ;
            double res = ds.Calculate(x);
            double wait = 0.25;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -13;
            double res = ds.Calculate(x);
            double wait = 28561.231;
            Assert.AreEqual(wait, res);
        }
    }
}