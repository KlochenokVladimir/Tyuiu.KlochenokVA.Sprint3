using Tyuiu.KlochenokVA.Sprint3.Task3.V1.Lib;

namespace Tyuiu.KlochenokVA.Sprint3.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'a';

            int res = ds.GetCharCount(value, item);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
