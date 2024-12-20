using Tyuiu.KhrapovDY.Sprint3.Task2.V18.Lib;

namespace Tyuiu.KhrapovDY.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 287.18;

            Assert.AreEqual(wait, res);
        }
    }
}