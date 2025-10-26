using Tyuiu.IvanovMS.Sprint3.Task0.V18.Lib;
namespace Tyuiu.IvanovMS.Sprint3.Task0.V18.Test
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
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 103.141;

            Assert.AreEqual(wait, res);
        }
    }
}
