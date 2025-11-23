using Tyuiu.KlochenokVA.Sprint3.Task4.V13.Lib;

namespace Tyuiu.KlochenokVA.Sprint3.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 14.914;
            Assert.AreEqual(wait, res);
        }
    }
}