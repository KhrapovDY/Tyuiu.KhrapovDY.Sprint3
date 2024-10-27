using Tyuiu.KhrapovDY.Sprint3.Task3.V30.Lib;

namespace Tyuiu.KhrapovDY.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "fyyklbtyn ygrc vfyyyyh";
            char item = 'y';

            int res = ds.GetMaxCharCount(value, item);

            int wait = 8;

            Assert.AreEqual(wait, res);

        }
    }
}