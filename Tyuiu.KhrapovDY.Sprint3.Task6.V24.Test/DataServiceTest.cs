using Tyuiu.KhrapovDY.Sprint3.Task6.V24.Lib;

namespace Tyuiu.KhrapovDY.Sprint3.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 26;
            
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 344;

            Assert.AreEqual(wait, res);
        }
    }
}