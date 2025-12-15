using Tyuiu.IvanovMS.Sprint3.Task3.V7.Lib;
namespace Tyuiu.IvanovMS.Sprint3.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string str = "gft hggt ntg";
            char repleacable = 'g';
            char replacement = '4';
            string wait = "4ft h44t nt4";
            var res = ds.ReplaceCharOnNum(str, repleacable, replacement);
            
            Assert.AreEqual(res, wait);
        }
    }
}
