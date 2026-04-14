using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KlochenokVA.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            do
            {
                multSeries *= Math.Pow(3 / (startValue + Math.Pow(value, -startValue)), 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}