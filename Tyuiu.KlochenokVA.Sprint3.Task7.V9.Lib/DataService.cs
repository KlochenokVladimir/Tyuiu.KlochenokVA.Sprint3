using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KlochenokVA.Sprint3.Task7.V9.Lib
{
    public class DataService : ISprint3Task7V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;
            int len = (stopValue - startValue) + 1;
            array = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                //if (Math.Cos(i) - 2 * i == 0)
                //{
                //count++;
                //
                //else 
                //{
                y = Math.Round((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - Math.Sin(i), 2);
                array[count] = y;
                count++;
                //}
            }
            return array;
        }
    }
}
