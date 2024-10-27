using Tyuiu.KhrapovDY.Sprint3.Task4.V15.Lib;

namespace Tyuiu.KhrapovDY.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 623.499;
            Assert.AreEqual(wait, res);
        }
    }
}