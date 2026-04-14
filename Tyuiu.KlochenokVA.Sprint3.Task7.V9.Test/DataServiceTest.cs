using Tyuiu.KlochenokVA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.KlochenokVA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] array;
            array = new double[len];
            array[0] = -27.22;
            array[1] = -22.25;
            array[2] = -16.66;
            array[3] = -11.04;
            array[4] = -6.13;
            array[5] = -3.00;
            array[6] = 4.84;
            array[7] = 8.86;
            array[8] = 14.43;
            array[9] = 20.18;
            array[10] = 25.24;
            double[] array2;
            array2 = new double[len];
            array2 = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(array, array2);
        }
    }
}
