using Tyuiu.KlochenokVA.Sprint3.Task6.V20.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.KlochenokVA.Sprint3.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 32;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(41, res);
        }
    }
}
