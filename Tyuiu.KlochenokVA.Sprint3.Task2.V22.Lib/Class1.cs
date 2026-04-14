using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KlochenokVA.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            int i = 1;
            do
            {
                res *= (3 / (i + Math.Pow(value, -i))) * (3 / (i + Math.Pow(value, -i)));
                i++;
            } while (i <= 7);
            return Math.Round(res, 3);

        }
    }
}