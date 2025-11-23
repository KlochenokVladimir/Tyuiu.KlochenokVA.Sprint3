using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KlochenokVA.Sprint3.Task4.V13.Lib
{
    public class DataService : ISprint3Task4V13
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                
                double y = (Math.Sin(x) / x) + 1.5;
                
                if (y < 0)
                {
                    break; 
                }
                
                sum += y;
            }
            return Math.Round(sum, 3);
        }
    }
}
