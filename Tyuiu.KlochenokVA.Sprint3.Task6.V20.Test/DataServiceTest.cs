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

            int startValue = 10;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 284;
            Assert.AreEqual(wait, res);
        }
    }
}
