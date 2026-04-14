using Tyuiu.KlochenokVA.Sprint3.Task2.V22.Lib;
namespace Tyuiu.KlochenokVA.Sprint3.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesValid()
        {
            DataService ds = new DataService();
            int x = 5;
            int st = 1;
            int en = 7;
            double wait = 0.125;
            double res = ds.GetMultiplySeries(x, st, en);
            Assert.AreEqual(wait, res);
        }
    }
}