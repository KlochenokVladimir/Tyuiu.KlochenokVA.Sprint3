using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KlochenokVA.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (double j = startValue2; j <= stopValue2; j++)
                {
                    res += ((x * 1.0) / j) + Math.Sin(x);
                }
            }

            return Math.Round(res, 3);
        }
    }
}
