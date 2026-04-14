using Tyuiu.KlochenokVA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.KlochenokVA.Sprint3.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции          *");
            Console.WriteLine("* F(x) = (2*x-3)/(cos(x)+x) + 5 на заданном диапазоне [-5; 5]          *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль.                       *");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue, stopValue;
            Console.WriteLine("Введите начальное значение : ");
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение : ");
            stopValue = Convert.ToInt32(Console.ReadLine());
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] array;
            array = new double[len];
            array = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0, 5:d}   | {1, 5:f2}   |", startValue, array[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
